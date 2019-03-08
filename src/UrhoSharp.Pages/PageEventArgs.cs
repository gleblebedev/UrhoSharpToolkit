using System;

namespace UrhoSharp.Pages
{
    public class PageEventArgs : EventArgs
    {
        private readonly IScenePage _page;

        public PageEventArgs(IScenePage page)
        {
            _page = page;
        }

        public IScenePage Page
        {
            get { return _page; }
        }
    }
}