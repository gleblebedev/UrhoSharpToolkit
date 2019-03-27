using System;

namespace UrhoSharp.Pages
{
    public class PageEventArgs : EventArgs
    {
        public PageEventArgs(IScenePage page)
        {
            Page = page;
        }

        public IScenePage Page { get; }
    }
}