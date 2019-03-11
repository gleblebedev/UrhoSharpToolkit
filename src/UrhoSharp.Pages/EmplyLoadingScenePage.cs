using System;
using System.Linq;
using System.Runtime.InteropServices;
using Urho;

namespace UrhoSharp.Pages
{
    public class EmplyLoadingScenePage : AbstractSingleScenePage, ILoadingProgress
    {
        private Node _animatedNode;
        private float _angle = 0.0f;
        public EmplyLoadingScenePage()
        {
            CreateSimpleScene(100);
            _animatedNode = Scene.CreateChild("WaitAnimation");
            var geometry = MakeLoadingModel(0.5f);
            _animatedNode.AddComponent(geometry);
            _animatedNode.Position = Vector3.Forward * 2;
            Camera.Node.LookAt(_animatedNode.Position, Vector3.Up);
        }

        public static CustomGeometry MakeLoadingModel(float radius)
        {
            var geometry = new CustomGeometry();
            geometry.BeginGeometry(0, PrimitiveType.TriangleList);
            int numSegments = 10;

            var k = Enumerable.Range(0, numSegments + 1).Select(_ => _ / ((float)numSegments)).ToList();
            var a = k.Select(_ => -MathHelper.Pi * _ * 0.25f).ToList();
            var v = a.Select(_ => new Vector3((float)Math.Cos(_), (float)Math.Sin(_), 0.0f)).ToList();
            var r = k.Select(_ => Bernstein(new Vector4(0.0f, 0.02f, 0.1f, 0.005f), _)).ToList();
            var c = k.Select(_ => new Color(_, _, _, _)).ToList();
            for (int i = 0; i < numSegments; ++i)
            {
                var v1 = v[i];
                var v2 = v[i + 1];
                var r1 = r[i];
                var r2 = r[i + 1];
                var c1 = c[i];
                var c2 = c[i + 1];

                geometry.DefineVertex(v1 * (radius - r1));
                geometry.DefineColor(c1);
                geometry.DefineVertex(v1 * (radius + r1));
                geometry.DefineColor(c1);
                geometry.DefineVertex(v2 * (radius + r2));
                geometry.DefineColor(c2);

                geometry.DefineVertex(v1 * (radius - r1));
                geometry.DefineColor(c1);
                geometry.DefineVertex(v2 * (radius + r2));
                geometry.DefineColor(c2);
                geometry.DefineVertex(v2 * (radius - r2));
                geometry.DefineColor(c2);

                v1 = -v1;
                v2 = -v2;

                geometry.DefineVertex(v1 * (radius - r1));
                geometry.DefineColor(c1);
                geometry.DefineVertex(v1 * (radius + r1));
                geometry.DefineColor(c1);
                geometry.DefineVertex(v2 * (radius + r2));
                geometry.DefineColor(c2);

                geometry.DefineVertex(v1 * (radius - r1));
                geometry.DefineColor(c1);
                geometry.DefineVertex(v2 * (radius + r2));
                geometry.DefineColor(c2);
                geometry.DefineVertex(v2 * (radius - r2));
                geometry.DefineColor(c2);
            }
            geometry.Commit();
            var mat = new Material();
            mat.SetTechnique(0, Urho.Application.Current.ResourceCache.GetTechnique("Techniques/NoTextureUnlitVCol.xml"), 1, 1);
            geometry.SetMaterial(mat);
            return geometry;
        }

        public void ReportProgress(int index, int count, string message)
        {
        }

        public override void OnActivated()
        {
            base.OnActivated();
            _angle = 0;
        }

        public override void Update(float timeStep)
        {
            base.Update(timeStep);

            _animatedNode.Rotation = Quaternion.FromAxisAngle(Vector3.Forward, -_angle);
            _angle += timeStep * 180;
        }
        static float Bernstein(Vector4 k, float t)
        {
            var _t = 1.0f - t;
            return k.X * _t * _t * _t + 3.0f * k.Y * _t * _t * t + 3.0f * k.Z * _t * t * t + k.W * t * t * t;
        }
    }
}