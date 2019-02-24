using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.Interfaces;
using UrhoSharp.Pages;
using UrhoSharp.Rx;

namespace UrhoSharp.Toolkit.Demo
{
    public class GameScenePage : AbstractSingleScenePage
    {
        private readonly IScenePage _menuPage;
        private readonly NavigationStack navigation;

        public GameScenePage(NavigationStack navigation, IScenePage menuPage)
        {
            this.navigation = navigation;
            _menuPage = menuPage;
            CreateSimpleScene(100);
            var zone = Scene.GetOrCreateComponent<Zone>();
            zone.FogColor = new Color(0, 0, 1, 1);
            var box = Scene.CreateChild();
            box.Position = new Vector3(0, 0, 4);
            var boxModel = box.CreateComponent<StaticModel>();
            boxModel.Model = ResourceCache.GetModel("Models/Box.mdl");
        }

        public override MouseMode MouseMode => MouseMode.Absolute;

        public override bool MouseGrabbed => true;

        public override bool MouseVisible => false;

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            for (var i = 0; i < 10; ++i)
            {
                progress.ReportProgress(i, 10, "Loading game");
                await Task.Delay(TimeSpan.FromSeconds(0.1));
            }
        }

        public override void OnActivated()
        {
            var music = ResourceCache.GetSound("Music/Lounge Game2.ogg");
            music.Looped = true;
            PlayMusic(music);
        }

        public override void OnJoystickButtonDown(object sender, JoystickButtonDownEventArguments args)
        {
            Trace.WriteLine("OnJoystickButtonDown " + args.JoystickID + ", button " + args.Button + "/" +
                            args.NumButtons);
            base.OnJoystickButtonDown(sender, args);
        }

        public override void OnJoystickButtonUp(object sender, JoystickButtonUpEventArguments args)
        {
            Trace.WriteLine("OnJoystickButtonUp " + args.JoystickID + ", button " + args.Button + "/" +
                            args.NumButtons);
            base.OnJoystickButtonUp(sender, args);
        }

        public override void OnJoystickAxisMove(object sender, JoystickAxisMoveEventArguments args)
        {
            Trace.WriteLine("OnJoystickAxisMove " + args.JoystickID + ", axis " + args.Axis + "/" + args.NumAxes);
            base.OnJoystickAxisMove(sender, args);
        }

        public override void OnKeyDown(object sender, KeyDownEventArguments args)
        {
            switch (args.Key)
            {
                case Key.Esc:
                    Task.Run(() => navigation.PushAsync(_menuPage));
                    break;
            }

            base.OnKeyDown(sender, args);
        }

        public override void OnTouchBegin(object sender, TouchBeginEventArguments args)
        {
            base.OnTouchBegin(sender, args);

            Task.Run(() => navigation.PushAsync(_menuPage));
        }
    }
}