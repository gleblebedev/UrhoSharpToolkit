using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class DropFileEventArguments : EventArgs
    {
        public DropFileEventArguments(DropFileEventArgs args)
        {
            FileName = args.FileName;
        }

        public string FileName { get; }
    }
}