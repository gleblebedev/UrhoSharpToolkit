using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Urho;
using UrhoSharp.Toolkit.Demo;

namespace UrhoSharp.Toolkit.DesktopDemo
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            var urhoOptions = new ApplicationOptions("Data");

            var _app = new DemoGame(urhoOptions);
            _app.Run();
        }
    }
}