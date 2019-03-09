using System;
using System.Xml.Linq;
using System.Collections.Generic;
using Urho;
using UrhoSharp.Prefabs.Accessors;
using Text3D = Urho.Gui.Text3D;

using Urho.Gui;

namespace UrhoSharp.Prefabs
{
    public partial class Text3DPrefab: AbstractComponentPrefab<Text3D>, IPrefab
    {
        public override string TypeName { get { return Text3D.TypeNameStatic; } }
        public float FontSize { get; set; }
        public Material Material { get; set; }
        public String Text { get; set; }
        public HorizontalAlignment HorizontalAlignment { get; set; }
        public VerticalAlignment VerticalAlignment { get; set; }
        public HorizontalAlignment TextAlignment { get; set; }
        public float RowSpacing { get; set; }
        public bool Wordwrap { get; set; }
        public TextEffect TextEffect { get; set; }
        public IntVector2 EffectShadowOffset { get; set; }
        public int EffectStrokeThickness { get; set; }
        public bool EffectRoundStroke { get; set; }
        public Color EffectColor { get; set; }
        public float EffectDepthBias { get; set; }
        public int Width { get; set; }
        public float Opacity { get; set; }
        public bool FixedScreenSize { get; set; }
        public FaceCameraMode FaceCameraMode { get; set; }
        public float DrawDistance { get; set; }
        public float ShadowDistance { get; set; }
        public float LodBias { get; set; }
        public uint ViewMask { get; set; }
        public uint LightMask { get; set; }
        public uint ShadowMask { get; set; }
        public uint ZoneMask { get; set; }
        public uint MaxLights { get; set; }
        public bool CastShadows { get; set; }
        public bool Occluder { get; set; }
        public bool Occludee { get; set; }
        public float SortValue { get; set; }
        public bool Enabled { get; set; }
        public bool AnimationEnabled { get; set; }
        public bool Temporary { get; set; }
        public bool BlockEvents { get; set; }
        public Text3DPrefab()
        {
            FontSize = FontSizeAccessor.DefaultValue;
            Material = MaterialAccessor.DefaultValue;
            Text = TextAccessor.DefaultValue;
            HorizontalAlignment = HorizontalAlignmentAccessor.DefaultValue;
            VerticalAlignment = VerticalAlignmentAccessor.DefaultValue;
            TextAlignment = TextAlignmentAccessor.DefaultValue;
            RowSpacing = RowSpacingAccessor.DefaultValue;
            Wordwrap = WordwrapAccessor.DefaultValue;
            TextEffect = TextEffectAccessor.DefaultValue;
            EffectShadowOffset = EffectShadowOffsetAccessor.DefaultValue;
            EffectStrokeThickness = EffectStrokeThicknessAccessor.DefaultValue;
            EffectRoundStroke = EffectRoundStrokeAccessor.DefaultValue;
            EffectColor = EffectColorAccessor.DefaultValue;
            EffectDepthBias = EffectDepthBiasAccessor.DefaultValue;
            Width = WidthAccessor.DefaultValue;
            Opacity = OpacityAccessor.DefaultValue;
            FixedScreenSize = FixedScreenSizeAccessor.DefaultValue;
            FaceCameraMode = FaceCameraModeAccessor.DefaultValue;
            DrawDistance = DrawDistanceAccessor.DefaultValue;
            ShadowDistance = ShadowDistanceAccessor.DefaultValue;
            LodBias = LodBiasAccessor.DefaultValue;
            ViewMask = ViewMaskAccessor.DefaultValue;
            LightMask = LightMaskAccessor.DefaultValue;
            ShadowMask = ShadowMaskAccessor.DefaultValue;
            ZoneMask = ZoneMaskAccessor.DefaultValue;
            MaxLights = MaxLightsAccessor.DefaultValue;
            CastShadows = CastShadowsAccessor.DefaultValue;
            Occluder = OccluderAccessor.DefaultValue;
            Occludee = OccludeeAccessor.DefaultValue;
            SortValue = SortValueAccessor.DefaultValue;
            Enabled = EnabledAccessor.DefaultValue;
            AnimationEnabled = AnimationEnabledAccessor.DefaultValue;
            Temporary = TemporaryAccessor.DefaultValue;
            BlockEvents = BlockEventsAccessor.DefaultValue;
        }
        public Text3DPrefab(Text3D val)
        {
            ID = val.ID;
            FontSize = val.FontSize;
            Material = val.Material;
            Text = val.Text;
            HorizontalAlignment = val.HorizontalAlignment;
            VerticalAlignment = val.VerticalAlignment;
            TextAlignment = val.TextAlignment;
            RowSpacing = val.RowSpacing;
            Wordwrap = val.Wordwrap;
            TextEffect = val.TextEffect;
            EffectShadowOffset = val.EffectShadowOffset;
            EffectStrokeThickness = val.EffectStrokeThickness;
            EffectRoundStroke = val.EffectRoundStroke;
            EffectColor = val.EffectColor;
            EffectDepthBias = val.EffectDepthBias;
            Width = val.Width;
            Opacity = val.Opacity;
            FixedScreenSize = val.FixedScreenSize;
            FaceCameraMode = val.FaceCameraMode;
            DrawDistance = val.DrawDistance;
            ShadowDistance = val.ShadowDistance;
            LodBias = val.LodBias;
            ViewMask = val.ViewMask;
            LightMask = val.LightMask;
            ShadowMask = val.ShadowMask;
            ZoneMask = val.ZoneMask;
            MaxLights = val.MaxLights;
            CastShadows = val.CastShadows;
            Occluder = val.Occluder;
            Occludee = val.Occludee;
            SortValue = val.SortValue;
            Enabled = val.Enabled;
            AnimationEnabled = val.AnimationEnabled;
            Temporary = val.Temporary;
            BlockEvents = val.BlockEvents;
        }
        public override Text3D Create()
        {
            var result = new Text3D();
            FontSizeAccessor.Instance.ApplyIfChanged(this, result);
            MaterialAccessor.Instance.ApplyIfChanged(this, result);
            TextAccessor.Instance.ApplyIfChanged(this, result);
            HorizontalAlignmentAccessor.Instance.ApplyIfChanged(this, result);
            VerticalAlignmentAccessor.Instance.ApplyIfChanged(this, result);
            TextAlignmentAccessor.Instance.ApplyIfChanged(this, result);
            RowSpacingAccessor.Instance.ApplyIfChanged(this, result);
            WordwrapAccessor.Instance.ApplyIfChanged(this, result);
            TextEffectAccessor.Instance.ApplyIfChanged(this, result);
            EffectShadowOffsetAccessor.Instance.ApplyIfChanged(this, result);
            EffectStrokeThicknessAccessor.Instance.ApplyIfChanged(this, result);
            EffectRoundStrokeAccessor.Instance.ApplyIfChanged(this, result);
            EffectColorAccessor.Instance.ApplyIfChanged(this, result);
            EffectDepthBiasAccessor.Instance.ApplyIfChanged(this, result);
            WidthAccessor.Instance.ApplyIfChanged(this, result);
            OpacityAccessor.Instance.ApplyIfChanged(this, result);
            FixedScreenSizeAccessor.Instance.ApplyIfChanged(this, result);
            FaceCameraModeAccessor.Instance.ApplyIfChanged(this, result);
            DrawDistanceAccessor.Instance.ApplyIfChanged(this, result);
            ShadowDistanceAccessor.Instance.ApplyIfChanged(this, result);
            LodBiasAccessor.Instance.ApplyIfChanged(this, result);
            ViewMaskAccessor.Instance.ApplyIfChanged(this, result);
            LightMaskAccessor.Instance.ApplyIfChanged(this, result);
            ShadowMaskAccessor.Instance.ApplyIfChanged(this, result);
            ZoneMaskAccessor.Instance.ApplyIfChanged(this, result);
            MaxLightsAccessor.Instance.ApplyIfChanged(this, result);
            CastShadowsAccessor.Instance.ApplyIfChanged(this, result);
            OccluderAccessor.Instance.ApplyIfChanged(this, result);
            OccludeeAccessor.Instance.ApplyIfChanged(this, result);
            SortValueAccessor.Instance.ApplyIfChanged(this, result);
            EnabledAccessor.Instance.ApplyIfChanged(this, result);
            AnimationEnabledAccessor.Instance.ApplyIfChanged(this, result);
            TemporaryAccessor.Instance.ApplyIfChanged(this, result);
            BlockEventsAccessor.Instance.ApplyIfChanged(this, result);
            return result;
        }

        public override void ParseXmlAttribute(string name, string value)
        {
            switch (name)
            {
                case "FontSize":
                    FontSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Material":
                    MaterialAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Text":
                    TextAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "HorizontalAlignment":
                    HorizontalAlignmentAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "VerticalAlignment":
                    VerticalAlignmentAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TextAlignment":
                    TextAlignmentAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "RowSpacing":
                    RowSpacingAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Wordwrap":
                    WordwrapAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "TextEffect":
                    TextEffectAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EffectShadowOffset":
                    EffectShadowOffsetAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EffectStrokeThickness":
                    EffectStrokeThicknessAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EffectRoundStroke":
                    EffectRoundStrokeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EffectColor":
                    EffectColorAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "EffectDepthBias":
                    EffectDepthBiasAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Width":
                    WidthAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Opacity":
                    OpacityAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FixedScreenSize":
                    FixedScreenSizeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "FaceCameraMode":
                    FaceCameraModeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "DrawDistance":
                    DrawDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowDistance":
                    ShadowDistanceAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LodBias":
                    LodBiasAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ViewMask":
                    ViewMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "LightMask":
                    LightMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ShadowMask":
                    ShadowMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "ZoneMask":
                    ZoneMaskAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "MaxLights":
                    MaxLightsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "CastShadows":
                    CastShadowsAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Occluder":
                    OccluderAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Occludee":
                    OccludeeAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "SortValue":
                    SortValueAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Is Enabled":
                    EnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "AnimationEnabled":
                    AnimationEnabledAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "Temporary":
                    TemporaryAccessor.Instance.ParseAndSet(value, this);
                    break;
                case "BlockEvents":
                    BlockEventsAccessor.Instance.ParseAndSet(value, this);
                    break;
                default:
                    throw new NotImplementedException("Property "+name+" not implemented yet.");
            }
        }
        #region Accessors
        public override IEnumerable<IAccessor> Properties {
            get {
                yield return FontSizeAccessor.Instance;
                yield return MaterialAccessor.Instance;
                yield return TextAccessor.Instance;
                yield return HorizontalAlignmentAccessor.Instance;
                yield return VerticalAlignmentAccessor.Instance;
                yield return TextAlignmentAccessor.Instance;
                yield return RowSpacingAccessor.Instance;
                yield return WordwrapAccessor.Instance;
                yield return TextEffectAccessor.Instance;
                yield return EffectShadowOffsetAccessor.Instance;
                yield return EffectStrokeThicknessAccessor.Instance;
                yield return EffectRoundStrokeAccessor.Instance;
                yield return EffectColorAccessor.Instance;
                yield return EffectDepthBiasAccessor.Instance;
                yield return WidthAccessor.Instance;
                yield return OpacityAccessor.Instance;
                yield return FixedScreenSizeAccessor.Instance;
                yield return FaceCameraModeAccessor.Instance;
                yield return DrawDistanceAccessor.Instance;
                yield return ShadowDistanceAccessor.Instance;
                yield return LodBiasAccessor.Instance;
                yield return ViewMaskAccessor.Instance;
                yield return LightMaskAccessor.Instance;
                yield return ShadowMaskAccessor.Instance;
                yield return ZoneMaskAccessor.Instance;
                yield return MaxLightsAccessor.Instance;
                yield return CastShadowsAccessor.Instance;
                yield return OccluderAccessor.Instance;
                yield return OccludeeAccessor.Instance;
                yield return SortValueAccessor.Instance;
                yield return EnabledAccessor.Instance;
                yield return AnimationEnabledAccessor.Instance;
                yield return TemporaryAccessor.Instance;
                yield return BlockEventsAccessor.Instance;
            }
        }

        internal class FontSizeAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly FontSizeAccessor Instance = new FontSizeAccessor();
            public static readonly float DefaultValue = 12f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.FontSize);
            public override float GetPrefab(Text3DPrefab instance) { return instance.FontSize; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.FontSize = value; }
            public override float GetUrho(Text3D instance) { return instance.FontSize; }
            public override void SetUrho(Text3D instance, float value) { instance.FontSize = value; }
        }

        internal class MaterialAccessor : MaterialAccessor<Text3DPrefab, Text3D>
        {
            public static readonly MaterialAccessor Instance = new MaterialAccessor();
            public static readonly Material DefaultValue = null;
            public override Material DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Material);
            public override Material GetPrefab(Text3DPrefab instance) { return instance.Material; }
            public override void SetPrefab(Text3DPrefab instance, Material value) { instance.Material = value; }
            public override Material GetUrho(Text3D instance) { return instance.Material; }
            public override void SetUrho(Text3D instance, Material value) { instance.Material = value; }
        }

        internal class TextAccessor : StringAccessor<Text3DPrefab, Text3D>
        {
            public static readonly TextAccessor Instance = new TextAccessor();
            public static readonly String DefaultValue = "";
            public override String DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Text);
            public override String GetPrefab(Text3DPrefab instance) { return instance.Text; }
            public override void SetPrefab(Text3DPrefab instance, String value) { instance.Text = value; }
            public override String GetUrho(Text3D instance) { return instance.Text; }
            public override void SetUrho(Text3D instance, String value) { instance.Text = value; }
        }

        internal class HorizontalAlignmentAccessor : EnumAccessor<Text3DPrefab, Text3D, HorizontalAlignment>
        {
            public static readonly HorizontalAlignmentAccessor Instance = new HorizontalAlignmentAccessor();
            public static readonly HorizontalAlignment DefaultValue = HorizontalAlignment.Left;
            public override HorizontalAlignment DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.HorizontalAlignment);
            public override HorizontalAlignment GetPrefab(Text3DPrefab instance) { return instance.HorizontalAlignment; }
            public override void SetPrefab(Text3DPrefab instance, HorizontalAlignment value) { instance.HorizontalAlignment = value; }
            public override HorizontalAlignment GetUrho(Text3D instance) { return instance.HorizontalAlignment; }
            public override void SetUrho(Text3D instance, HorizontalAlignment value) { instance.HorizontalAlignment = value; }
        }

        internal class VerticalAlignmentAccessor : EnumAccessor<Text3DPrefab, Text3D, VerticalAlignment>
        {
            public static readonly VerticalAlignmentAccessor Instance = new VerticalAlignmentAccessor();
            public static readonly VerticalAlignment DefaultValue = VerticalAlignment.Top;
            public override VerticalAlignment DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.VerticalAlignment);
            public override VerticalAlignment GetPrefab(Text3DPrefab instance) { return instance.VerticalAlignment; }
            public override void SetPrefab(Text3DPrefab instance, VerticalAlignment value) { instance.VerticalAlignment = value; }
            public override VerticalAlignment GetUrho(Text3D instance) { return instance.VerticalAlignment; }
            public override void SetUrho(Text3D instance, VerticalAlignment value) { instance.VerticalAlignment = value; }
        }

        internal class TextAlignmentAccessor : EnumAccessor<Text3DPrefab, Text3D, HorizontalAlignment>
        {
            public static readonly TextAlignmentAccessor Instance = new TextAlignmentAccessor();
            public static readonly HorizontalAlignment DefaultValue = HorizontalAlignment.Left;
            public override HorizontalAlignment DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.TextAlignment);
            public override HorizontalAlignment GetPrefab(Text3DPrefab instance) { return instance.TextAlignment; }
            public override void SetPrefab(Text3DPrefab instance, HorizontalAlignment value) { instance.TextAlignment = value; }
            public override HorizontalAlignment GetUrho(Text3D instance) { return instance.TextAlignment; }
            public override void SetUrho(Text3D instance, HorizontalAlignment value) { instance.TextAlignment = value; }
        }

        internal class RowSpacingAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly RowSpacingAccessor Instance = new RowSpacingAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.RowSpacing);
            public override float GetPrefab(Text3DPrefab instance) { return instance.RowSpacing; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.RowSpacing = value; }
            public override float GetUrho(Text3D instance) { return instance.RowSpacing; }
            public override void SetUrho(Text3D instance, float value) { instance.RowSpacing = value; }
        }

        internal class WordwrapAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly WordwrapAccessor Instance = new WordwrapAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Wordwrap);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.Wordwrap; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.Wordwrap = value; }
            public override bool GetUrho(Text3D instance) { return instance.Wordwrap; }
            public override void SetUrho(Text3D instance, bool value) { instance.Wordwrap = value; }
        }

        internal class TextEffectAccessor : EnumAccessor<Text3DPrefab, Text3D, TextEffect>
        {
            public static readonly TextEffectAccessor Instance = new TextEffectAccessor();
            public static readonly TextEffect DefaultValue = TextEffect.None;
            public override TextEffect DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.TextEffect);
            public override TextEffect GetPrefab(Text3DPrefab instance) { return instance.TextEffect; }
            public override void SetPrefab(Text3DPrefab instance, TextEffect value) { instance.TextEffect = value; }
            public override TextEffect GetUrho(Text3D instance) { return instance.TextEffect; }
            public override void SetUrho(Text3D instance, TextEffect value) { instance.TextEffect = value; }
        }

        internal class EffectShadowOffsetAccessor : IntVector2Accessor<Text3DPrefab, Text3D>
        {
            public static readonly EffectShadowOffsetAccessor Instance = new EffectShadowOffsetAccessor();
            public static readonly IntVector2 DefaultValue = new IntVector2(1, 1);
            public override IntVector2 DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.EffectShadowOffset);
            public override IntVector2 GetPrefab(Text3DPrefab instance) { return instance.EffectShadowOffset; }
            public override void SetPrefab(Text3DPrefab instance, IntVector2 value) { instance.EffectShadowOffset = value; }
            public override IntVector2 GetUrho(Text3D instance) { return instance.EffectShadowOffset; }
            public override void SetUrho(Text3D instance, IntVector2 value) { instance.EffectShadowOffset = value; }
        }

        internal class EffectStrokeThicknessAccessor : Int32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly EffectStrokeThicknessAccessor Instance = new EffectStrokeThicknessAccessor();
            public static readonly int DefaultValue = 1;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.EffectStrokeThickness);
            public override int GetPrefab(Text3DPrefab instance) { return instance.EffectStrokeThickness; }
            public override void SetPrefab(Text3DPrefab instance, int value) { instance.EffectStrokeThickness = value; }
            public override int GetUrho(Text3D instance) { return instance.EffectStrokeThickness; }
            public override void SetUrho(Text3D instance, int value) { instance.EffectStrokeThickness = value; }
        }

        internal class EffectRoundStrokeAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly EffectRoundStrokeAccessor Instance = new EffectRoundStrokeAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.EffectRoundStroke);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.EffectRoundStroke; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.EffectRoundStroke = value; }
            public override bool GetUrho(Text3D instance) { return instance.EffectRoundStroke; }
            public override void SetUrho(Text3D instance, bool value) { instance.EffectRoundStroke = value; }
        }

        internal class EffectColorAccessor : ColorAccessor<Text3DPrefab, Text3D>
        {
            public static readonly EffectColorAccessor Instance = new EffectColorAccessor();
            public static readonly Color DefaultValue = new Color(0f, 0f, 0f, 1f);
            public override Color DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.EffectColor);
            public override Color GetPrefab(Text3DPrefab instance) { return instance.EffectColor; }
            public override void SetPrefab(Text3DPrefab instance, Color value) { instance.EffectColor = value; }
            public override Color GetUrho(Text3D instance) { return instance.EffectColor; }
            public override void SetUrho(Text3D instance, Color value) { instance.EffectColor = value; }
        }

        internal class EffectDepthBiasAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly EffectDepthBiasAccessor Instance = new EffectDepthBiasAccessor();
            public static readonly float DefaultValue = 0.1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.EffectDepthBias);
            public override float GetPrefab(Text3DPrefab instance) { return instance.EffectDepthBias; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.EffectDepthBias = value; }
            public override float GetUrho(Text3D instance) { return instance.EffectDepthBias; }
            public override void SetUrho(Text3D instance, float value) { instance.EffectDepthBias = value; }
        }

        internal class WidthAccessor : Int32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly WidthAccessor Instance = new WidthAccessor();
            public static readonly int DefaultValue = 0;
            public override int DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Width);
            public override int GetPrefab(Text3DPrefab instance) { return instance.Width; }
            public override void SetPrefab(Text3DPrefab instance, int value) { instance.Width = value; }
            public override int GetUrho(Text3D instance) { return instance.Width; }
            public override void SetUrho(Text3D instance, int value) { instance.Width = value; }
        }

        internal class OpacityAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly OpacityAccessor Instance = new OpacityAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Opacity);
            public override float GetPrefab(Text3DPrefab instance) { return instance.Opacity; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.Opacity = value; }
            public override float GetUrho(Text3D instance) { return instance.Opacity; }
            public override void SetUrho(Text3D instance, float value) { instance.Opacity = value; }
        }

        internal class FixedScreenSizeAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly FixedScreenSizeAccessor Instance = new FixedScreenSizeAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.FixedScreenSize);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.FixedScreenSize; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.FixedScreenSize = value; }
            public override bool GetUrho(Text3D instance) { return instance.FixedScreenSize; }
            public override void SetUrho(Text3D instance, bool value) { instance.FixedScreenSize = value; }
        }

        internal class FaceCameraModeAccessor : EnumAccessor<Text3DPrefab, Text3D, FaceCameraMode>
        {
            public static readonly FaceCameraModeAccessor Instance = new FaceCameraModeAccessor();
            public static readonly FaceCameraMode DefaultValue = FaceCameraMode.None;
            public override FaceCameraMode DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.FaceCameraMode);
            public override FaceCameraMode GetPrefab(Text3DPrefab instance) { return instance.FaceCameraMode; }
            public override void SetPrefab(Text3DPrefab instance, FaceCameraMode value) { instance.FaceCameraMode = value; }
            public override FaceCameraMode GetUrho(Text3D instance) { return instance.FaceCameraMode; }
            public override void SetUrho(Text3D instance, FaceCameraMode value) { instance.FaceCameraMode = value; }
        }

        internal class DrawDistanceAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly DrawDistanceAccessor Instance = new DrawDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.DrawDistance);
            public override float GetPrefab(Text3DPrefab instance) { return instance.DrawDistance; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.DrawDistance = value; }
            public override float GetUrho(Text3D instance) { return instance.DrawDistance; }
            public override void SetUrho(Text3D instance, float value) { instance.DrawDistance = value; }
        }

        internal class ShadowDistanceAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly ShadowDistanceAccessor Instance = new ShadowDistanceAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.ShadowDistance);
            public override float GetPrefab(Text3DPrefab instance) { return instance.ShadowDistance; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.ShadowDistance = value; }
            public override float GetUrho(Text3D instance) { return instance.ShadowDistance; }
            public override void SetUrho(Text3D instance, float value) { instance.ShadowDistance = value; }
        }

        internal class LodBiasAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly LodBiasAccessor Instance = new LodBiasAccessor();
            public static readonly float DefaultValue = 1f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.LodBias);
            public override float GetPrefab(Text3DPrefab instance) { return instance.LodBias; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.LodBias = value; }
            public override float GetUrho(Text3D instance) { return instance.LodBias; }
            public override void SetUrho(Text3D instance, float value) { instance.LodBias = value; }
        }

        internal class ViewMaskAccessor : UInt32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly ViewMaskAccessor Instance = new ViewMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.ViewMask);
            public override uint GetPrefab(Text3DPrefab instance) { return instance.ViewMask; }
            public override void SetPrefab(Text3DPrefab instance, uint value) { instance.ViewMask = value; }
            public override uint GetUrho(Text3D instance) { return instance.ViewMask; }
            public override void SetUrho(Text3D instance, uint value) { instance.ViewMask = value; }
        }

        internal class LightMaskAccessor : UInt32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly LightMaskAccessor Instance = new LightMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.LightMask);
            public override uint GetPrefab(Text3DPrefab instance) { return instance.LightMask; }
            public override void SetPrefab(Text3DPrefab instance, uint value) { instance.LightMask = value; }
            public override uint GetUrho(Text3D instance) { return instance.LightMask; }
            public override void SetUrho(Text3D instance, uint value) { instance.LightMask = value; }
        }

        internal class ShadowMaskAccessor : UInt32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly ShadowMaskAccessor Instance = new ShadowMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.ShadowMask);
            public override uint GetPrefab(Text3DPrefab instance) { return instance.ShadowMask; }
            public override void SetPrefab(Text3DPrefab instance, uint value) { instance.ShadowMask = value; }
            public override uint GetUrho(Text3D instance) { return instance.ShadowMask; }
            public override void SetUrho(Text3D instance, uint value) { instance.ShadowMask = value; }
        }

        internal class ZoneMaskAccessor : UInt32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly ZoneMaskAccessor Instance = new ZoneMaskAccessor();
            public static readonly uint DefaultValue = 4294967295;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.ZoneMask);
            public override uint GetPrefab(Text3DPrefab instance) { return instance.ZoneMask; }
            public override void SetPrefab(Text3DPrefab instance, uint value) { instance.ZoneMask = value; }
            public override uint GetUrho(Text3D instance) { return instance.ZoneMask; }
            public override void SetUrho(Text3D instance, uint value) { instance.ZoneMask = value; }
        }

        internal class MaxLightsAccessor : UInt32Accessor<Text3DPrefab, Text3D>
        {
            public static readonly MaxLightsAccessor Instance = new MaxLightsAccessor();
            public static readonly uint DefaultValue = 0;
            public override uint DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.MaxLights);
            public override uint GetPrefab(Text3DPrefab instance) { return instance.MaxLights; }
            public override void SetPrefab(Text3DPrefab instance, uint value) { instance.MaxLights = value; }
            public override uint GetUrho(Text3D instance) { return instance.MaxLights; }
            public override void SetUrho(Text3D instance, uint value) { instance.MaxLights = value; }
        }

        internal class CastShadowsAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly CastShadowsAccessor Instance = new CastShadowsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.CastShadows);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.CastShadows; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.CastShadows = value; }
            public override bool GetUrho(Text3D instance) { return instance.CastShadows; }
            public override void SetUrho(Text3D instance, bool value) { instance.CastShadows = value; }
        }

        internal class OccluderAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly OccluderAccessor Instance = new OccluderAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Occluder);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.Occluder; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.Occluder = value; }
            public override bool GetUrho(Text3D instance) { return instance.Occluder; }
            public override void SetUrho(Text3D instance, bool value) { instance.Occluder = value; }
        }

        internal class OccludeeAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly OccludeeAccessor Instance = new OccludeeAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Occludee);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.Occludee; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.Occludee = value; }
            public override bool GetUrho(Text3D instance) { return instance.Occludee; }
            public override void SetUrho(Text3D instance, bool value) { instance.Occludee = value; }
        }

        internal class SortValueAccessor : SingleAccessor<Text3DPrefab, Text3D>
        {
            public static readonly SortValueAccessor Instance = new SortValueAccessor();
            public static readonly float DefaultValue = 0f;
            public override float DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.SortValue);
            public override float GetPrefab(Text3DPrefab instance) { return instance.SortValue; }
            public override void SetPrefab(Text3DPrefab instance, float value) { instance.SortValue = value; }
            public override float GetUrho(Text3D instance) { return instance.SortValue; }
            public override void SetUrho(Text3D instance, float value) { instance.SortValue = value; }
        }

        internal class EnabledAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly EnabledAccessor Instance = new EnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Enabled);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.Enabled; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.Enabled = value; }
            public override bool GetUrho(Text3D instance) { return instance.Enabled; }
            public override void SetUrho(Text3D instance, bool value) { instance.Enabled = value; }
        }

        internal class AnimationEnabledAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly AnimationEnabledAccessor Instance = new AnimationEnabledAccessor();
            public static readonly bool DefaultValue = true;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.AnimationEnabled);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.AnimationEnabled; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.AnimationEnabled = value; }
            public override bool GetUrho(Text3D instance) { return instance.AnimationEnabled; }
            public override void SetUrho(Text3D instance, bool value) { instance.AnimationEnabled = value; }
        }

        internal class TemporaryAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly TemporaryAccessor Instance = new TemporaryAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.Temporary);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.Temporary; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.Temporary = value; }
            public override bool GetUrho(Text3D instance) { return instance.Temporary; }
            public override void SetUrho(Text3D instance, bool value) { instance.Temporary = value; }
        }

        internal class BlockEventsAccessor : BooleanAccessor<Text3DPrefab, Text3D>
        {
            public static readonly BlockEventsAccessor Instance = new BlockEventsAccessor();
            public static readonly bool DefaultValue = false;
            public override bool DefaultPrefabValue => DefaultValue; 
            public override string Name => nameof(Text3D.BlockEvents);
            public override bool GetPrefab(Text3DPrefab instance) { return instance.BlockEvents; }
            public override void SetPrefab(Text3DPrefab instance, bool value) { instance.BlockEvents = value; }
            public override bool GetUrho(Text3D instance) { return instance.BlockEvents; }
            public override void SetUrho(Text3D instance, bool value) { instance.BlockEvents = value; }
        }

        #endregion
    }
}
