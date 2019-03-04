using System;
using Urho;
using UrhoSharp.Pages;

namespace UrhoSharp.Prefabs.Gen
{
    public class GenGame : AbstractNavigationApp
    {
        private CodeGen _gen;

        public GenGame(ApplicationOptions options, CodeGen gen) : base(options)
        {
            _gen = gen;
        }

        public GenGame(IntPtr handle) : base(handle)
        {
        }

        protected GenGame(UrhoObjectFlag emptyFlag) : base(emptyFlag)
        {
        }

        protected override void OnUpdate(float timeStep)
        {
            base.OnUpdate(timeStep);
            _gen?.Run();
            _gen = null;
            Exit();
        }
    }
}