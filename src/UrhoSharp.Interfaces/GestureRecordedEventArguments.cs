using System;
using Urho;

namespace UrhoSharp.Interfaces
{
    public class GestureRecordedEventArguments : EventArgs
    {
        public GestureRecordedEventArguments(GestureRecordedEventArgs args)
        {
            GestureID = args.GestureID;
        }

        public uint GestureID { get; }
    }
}