using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDesk.Options;
using Urho;
using UrhoSharp.Toolkit.Demo;

namespace UrhoSharp.Prefabs.Gen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var urhoOptions = new ApplicationOptions("Data");
            var gen = new CodeGen();
            var set = new OptionSet();

            set.Add("folder=", "Output directory", _ => gen.OutputFolder = _);
            var unknown = set.Parse(Environment.GetCommandLineArgs().Skip(1));
            if (unknown.Count > 0)
            {
                set.WriteOptionDescriptions(Console.Error);
                return;
            }

            Directory.CreateDirectory("Data");

            var _app = new GenGame(urhoOptions, gen);
            _app.Run();
        }
    }
}
