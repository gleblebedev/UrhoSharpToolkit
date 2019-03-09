using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Urho;
using Urho.Resources;
using Urho.SharpReality;
using Urho.Urho2D;

namespace UrhoSharp.Prefabs.Gen
{
    public class CodeGen
    {
        private string _outputFolder = Directory.GetCurrentDirectory();

        public static IEnumerable<Type> Components
        {
            get
            {
                foreach (var type in typeof(StaticModel).Module.GetTypes())
                {
                    if (typeof(Component).IsAssignableFrom(type) && !type.IsAbstract && type != typeof(YuvVideo) && type.Namespace != "Urho.SharpReality")
                    {
                        yield return type;
                    }
                }
            }
        }

        public string OutputFolder
        {
            get { return _outputFolder; }
            set { _outputFolder = value; }
        } 

        public string TypeName(Type t)
        {
            if (t == typeof(int))
                return "int";
            if (t == typeof(uint))
                return "uint";
            if (t == typeof(float))
                return "float";
            if (t == typeof(bool))
                return "bool";
            return t.Name;
        }


        public Component GenComponentPrefab(Type type, string className, TextWriter writer)
        {
            Component instance;
            if (type.GetConstructor(new Type[] { typeof(Context) }) != null)
                instance = (Component)Activator.CreateInstance(type, new[] { Urho.Application.Current.Context });
            else if (type.GetConstructor(new Type[] { }) != null)
                instance = (Component)Activator.CreateInstance(type);
            else
                return null;
            //var instance = Activator.CreateInstance(type);
            writer.WriteLine("using System;");
            writer.WriteLine("using System.Xml.Linq;");
            writer.WriteLine("using System.Collections.Generic;");
            writer.WriteLine("using Urho;");
            writer.WriteLine("using UrhoSharp.Prefabs.Accessors;");

            writer.WriteLine("using " + type.Name + " = " + type.Namespace + "." + type.Name + ";");
            writer.WriteLine("");
            if (type.Namespace != "Urho")
                writer.WriteLine("using "+type.Namespace+";");
            writer.WriteLine("");
            writer.WriteLine("namespace UrhoSharp.Prefabs");
            writer.WriteLine("{");
            writer.WriteLine("    public partial class " + className + ": AbstractComponentPrefab<" + type.Name + ">, IPrefab");
            writer.WriteLine("    {");
            writer.WriteLine("        public override string TypeName { get { return " + type.Name + ".TypeNameStatic; } }");
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(_ => _.CanWrite)
                .Where(_=>_.PropertyType != typeof(ObjectAnimation))
                .Where(_ => _.PropertyType != typeof(RenderPathCommand))
                .Where(_ => _.PropertyType != typeof(Texture2D))
                .Where(_ => _.PropertyType != typeof(Image))
                .Where(_=>!_.PropertyType.IsPointer)
                .Select(TranslateProperty)
                .ToList();

            //writer.WriteLine("        public uint? ID { get; set; }");
            foreach (var propertyInfo in properties)
            {
                writer.WriteLine("        public " + propertyInfo.ActualTypeName + " " + propertyInfo.Name + " { get; set; }");
            }

            writer.WriteLine("        public " + className + "()");
            writer.WriteLine("        {");
            foreach (var propertyInfo in properties)
            {
                writer.WriteLine("            " + propertyInfo.Name + " = " + propertyInfo.Name + "Accessor.DefaultValue;");
            }
            writer.WriteLine("        }");
            writer.WriteLine("        public " + className + "(" + type.Name + " val)");
            writer.WriteLine("        {");
            writer.WriteLine("            ID = val.ID;");
            foreach (var propertyInfo in properties)
            {
                writer.WriteLine("            " + propertyInfo.Name + " = val." + propertyInfo.Name + ";");
            }
            writer.WriteLine("        }");
            //foreach (var propertyInfo in properties)
            //{
            //    writer.WriteLine("        public " + propertyInfo.ActualTypeName + " " + propertyInfo.Name + " {get { return " + propertyInfo.FieldName + ";} set { " + propertyInfo.FieldName + "=value; } }");
            //    writer.WriteLine("        public bool " + propertyInfo.Name + "HasValue {get { return !PrefabUtils.AreEqual(ref " + propertyInfo.FieldName + ", ref " + propertyInfo.Name + "DefaultValue); } }");
            //}
            writer.WriteLine("        public override " + type.Name + " Create()");
            writer.WriteLine("        {");
            writer.WriteLine("            var result = new " + type.Name + "();");
            foreach (var propertyInfo in properties)
            {
                writer.WriteLine("            " + propertyInfo.Name + "Accessor.Instance.ApplyIfChanged(this, result);");
            }
            writer.WriteLine("            return result;");
            writer.WriteLine("        }");
            writer.WriteLine("");
            writer.WriteLine("        public override void ParseXmlAttribute(string name, string value)");
            writer.WriteLine("        {");
            writer.WriteLine("            switch (name)");
            writer.WriteLine("            {");
            foreach (var propertyInfo in properties)
            {
                writer.WriteLine("                case \"" +propertyInfo.XmlName+"\":");
                writer.WriteLine("                    " + propertyInfo.Name + "Accessor.Instance.ParseAndSet(value, this);");
                writer.WriteLine("                    break;");
            }
            writer.WriteLine("                default:");
            writer.WriteLine("                    throw new NotImplementedException(\"Property \"+name+\" not implemented yet.\");");
            writer.WriteLine("            }");
            writer.WriteLine("        }");

            writer.WriteLine("        #region Accessors");
            writer.WriteLine("        public override IEnumerable<IAccessor> Properties {");
            writer.WriteLine("            get {");
            foreach (var propertyInfo in properties)
            {
                writer.WriteLine("                yield return " + propertyInfo.Name + "Accessor.Instance;");
            }
            writer.WriteLine("            }");
            writer.WriteLine("        }");

            foreach (var propertyInfo in properties)
            {
                string baseType = propertyInfo.ActualType.Name + "Accessor<" + className + ", " + type.Name + ">";
                if (propertyInfo.ActualType.IsEnum)
                {
                    baseType = "EnumAccessor<" + className + ", " + type.Name + ", "+propertyInfo.ActualType.Name+">";
                }
                writer.WriteLine("");
                writer.WriteLine("        internal class " + propertyInfo.Name + "Accessor : "+ baseType);
                writer.WriteLine("        {");

                writer.WriteLine("            public static readonly " + propertyInfo.Name + "Accessor Instance = new " + propertyInfo.Name + "Accessor();");
                writer.WriteLine("            public static readonly " + propertyInfo.ActualTypeName + " DefaultValue = " + GetValue(propertyInfo.PropertyInfo, instance) + ";");
                writer.WriteLine("            public override " + propertyInfo.ActualTypeName + " DefaultPrefabValue => DefaultValue; ");

                writer.WriteLine("            public override string Name => nameof(" + type.Name + "." + propertyInfo.Name + ");");
                writer.WriteLine(
                    "            public override " + propertyInfo.ActualTypeName + " GetPrefab(" + className + " instance) { return instance." + propertyInfo.Name + "; }");
                writer.WriteLine(
                    "            public override void SetPrefab(" + className + " instance, " + propertyInfo.ActualTypeName + " value) { instance." + propertyInfo.Name + " = value; }");
                writer.WriteLine(
                    "            public override " + propertyInfo.ActualTypeName + " GetUrho(" + type.Name + " instance) { return instance." + propertyInfo.Name + "; }");
                writer.WriteLine(
                    "            public override void SetUrho(" + type.Name + " instance, " + propertyInfo.ActualTypeName + " value) { instance." + propertyInfo.Name + " = value; }");
                writer.WriteLine("        }");
            }

            writer.WriteLine("");
            writer.WriteLine("        #endregion");


            writer.WriteLine("    }");
            writer.WriteLine("}");
            return instance;
        }

        private ObjectProperty TranslateProperty(PropertyInfo property)
        {
            var p = new ObjectProperty() {PropertyInfo = property};
            p.Name = p.PropertyInfo.Name;
            switch (p.Name)
            {
                case "Enabled":
                    p.XmlName = "Is Enabled";
                    break;
                default:
                    p.XmlName = p.Name;
                    break;
            }
            p.PropertyType = p.PropertyInfo.PropertyType;
            p.ActualType = p.PropertyInfo.PropertyType;
            p.FieldName = "_"+p.Name.Substring(0, 1).ToLower() + p.Name.Substring(1);
            p.ActualTypeName = TypeName(p.ActualType);
            return p;
        }

        private string GetValue(PropertyInfo propertyInfo, object instance)
        {
            var type = propertyInfo.PropertyType;
            var val = propertyInfo.GetValue(instance, null);
            return GetValue(type, val);
        }

        private string GetValue(Type type, object val)
        {
            if (val == null)
                return "null";
            if (type == typeof(string))
                return EscapeString((string) val);
            if (type == typeof(bool))
                return string.Format(CultureInfo.InvariantCulture, "{0}", val).ToLower();
            if (type == typeof(float))
                return string.Format(CultureInfo.InvariantCulture, "{0}f", val);
            if (type.IsEnum)
            {
                return string.Format(CultureInfo.InvariantCulture, "{1}.{0}", val, type.Name);
            }

            if (type == typeof(Vector3))
            {
                var v = (Vector3) val;
                return string.Format(CultureInfo.InvariantCulture, "new Vector3({0}f, {1}f, {2}f)", v.X, v.Y, v.Z);
            }

            if (type == typeof(Vector2))
            {
                var v = (Vector2) val;
                return string.Format(CultureInfo.InvariantCulture, "new Vector2({0}f, {1}f)", v.X, v.Y);
            }

            if (type == typeof(IntVector2))
            {
                var v = (IntVector2) val;
                return string.Format(CultureInfo.InvariantCulture, "new IntVector2({0}, {1})", v.X, v.Y);
            }
            if (type == typeof(Vector4))
            {
                var v = (Vector4)val;
                return string.Format(CultureInfo.InvariantCulture, "new Vector4({0}f, {1}f, {2}f, {3}f)", v.X, v.Y, v.Z, v.W);
            }

            if (type == typeof(Quaternion))
            {
                var v = (Quaternion) val;
                return string.Format(CultureInfo.InvariantCulture, "new Quaternion({0}f, {1}f, {2}f, {3}f)", v.X, v.Y, v.Z, v.W);
            }

            if (type == typeof(BiasParameters))
            {
                var v = (BiasParameters) val;
                return string.Format(CultureInfo.InvariantCulture, "new BiasParameters({0}f, {1}f, {2}f)", v.ConstantBias,
                    v.SlopeScaleBias, v.NormalOffset);
            }

            if (type == typeof(CascadeParameters))
            {
                var v = (CascadeParameters) val;
                return string.Format(CultureInfo.InvariantCulture, "new CascadeParameters({0}f, {1}f, {2}f, {3}f, {4}f, {5}f)",
                    v.Split1, v.Split2, v.Split3, v.Split4, v.FadeStart, v.BiasAutoAdjust);
            }

            if (type == typeof(FocusParameters))
            {
                var v = (FocusParameters) val;
                return string.Format(CultureInfo.InvariantCulture,
                    "new FocusParameters() {{Focus = {0}, AutoSize = {1}, MinView = {2}f, NonUniform = {3}, Quantize = {4}f}}",
                    v.Focus, v.AutoSize, v.MinView, v.NonUniform, v.Quantize);
            }

            if (type == typeof(Color))
            {
                var v = (Color) val;

                return string.Format(CultureInfo.InvariantCulture, "new Color({0}f, {1}f, {2}f, {3}f)", v.R, v.G, v.B, v.A);
            }

            if (type == typeof(Plane))
            {
                var v = (Plane)val;

                return string.Format(CultureInfo.InvariantCulture, "new Plane({0})", GetValue(typeof(Vector4),new Vector4(v.Normal.X, v.Normal.Y, v.Normal.Z, v.D)));
            }
            //if (propertyInfo.PropertyType == typeof(int))
            //{
            //}
            return string.Format(CultureInfo.InvariantCulture, "{0}", val);
        }

        private string EscapeString(string val)
        {
            //TODO: Make proper conversion
            return "\"" + val + "\"";
        }

        public void Run()
        {
            foreach (var component in Components)
            {
                var className = component.Name + "Prefab";
                var ns = component.Namespace.Substring("Urho".Length).Replace('.','\\');
                var fullFileName = Path.Combine(OutputFolder+ns, className + ".cs");
                Directory.CreateDirectory(Path.GetDirectoryName(fullFileName));
                using (var file = File.Open(fullFileName, FileMode.Create,
                    FileAccess.Write, FileShare.Read))
                {
                    using (var stream = new StreamWriter(file, new UTF8Encoding(false)))
                    {
                        var c = GenComponentPrefab(component, className,stream);
                        if (c != null)
                        {
                            Trace.WriteLine("case " + c.Type.Code + ": return new "+className+"(("+component.Name+")component);");
                        }
                    }
                }
            }
        }
    }

    class ObjectProperty
    {
        public PropertyInfo PropertyInfo;
        public string Name;
        public string FieldName;
        public Type ActualType;
        public Type PropertyType;
        public string ActualTypeName;
        public string XmlName;
    }
}