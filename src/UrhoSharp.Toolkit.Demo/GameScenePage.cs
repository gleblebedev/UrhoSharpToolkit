﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Urho;
using UrhoSharp.Input;
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
            NextInputSubscriber = new FreeCameraController(CameraNode);

            this.MapTouch(OnTouch, OnTouchMove2, OnTouchComplete, OnTouchCancel2);
        }

        public override MouseMode MouseMode => MouseMode.Absolute;

        public override bool MouseGrabbed => true;

        public override bool MouseVisible => false;

        private void OnTouchCancel2()
        {
            Trace.WriteLine("OnTouchCancel");
        }

        private void OnTouch(TouchArgs args)
        {
            Trace.WriteLine("OnTouch " + args);
        }

        private void OnTouchComplete(TouchArgs args)
        {
            Trace.WriteLine("OnTouchComplete " + args);
        }

        private void OnTouchMove2(TouchArgs args)
        {
            Trace.WriteLine("OnTouchMove " + args);
        }

        protected override async Task PrepareAsync(IUrhoScheduler scheduler, ILoadingProgress progress)
        {
            var max = 10;
            for (var i = 0; i < max; ++i)
            {
                progress.ReportProgress(i, max, "Loading game");
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
            Trace.WriteLine("OnJoystickAxisMove " + args.JoystickID + ", axis " + args.Axis + "/" + args.NumAxes +
                            ", postion=" + args.Position);
            base.OnJoystickAxisMove(sender, args);
        }

        public override void OnJoystickHatMove(object sender, JoystickHatMoveEventArguments args)
        {
            Trace.WriteLine("OnJoystickHatMove " + args.JoystickID + ", hat " + args.Hat + "/" + args.NumHats +
                            ", postion=" + args.Position);
            base.OnJoystickHatMove(sender, args);
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

        //public override void OnTouchBegin(object sender, TouchBeginEventArguments args)
        //{
        //    base.OnTouchBegin(sender, args);

        //    Task.Run(() => navigation.PushAsync(_menuPage));
        //}
    }
}