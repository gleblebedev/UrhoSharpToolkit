using System.Collections.Generic;
using System.Threading.Tasks;

namespace UrhoSharp.HierarchicalNavigation
{
    public class NavigationStack
    {
        private readonly ICurrentPageContainer _container;
        private readonly object _gate = new object();
        private readonly Stack<IScenePage> _stack = new Stack<IScenePage>();

        public NavigationStack(ICurrentPageContainer container)
        {
            _container = container;
        }

        /// <summary>
        ///     Asynchronously removes the top Page from the navigation stack.
        /// </summary>
        public async Task<IScenePage> PopAsync()
        {
            IScenePage top = null;
            IScenePage res = null;
            lock (_gate)
            {
                if (_stack.Count > 0)
                {
                    res = _stack.Pop();
                    if (_stack.Count > 0) top = _stack.Peek();
                }
            }

            await _container.SetCurrentPageAsync(top);
            return res;
        }

        /// <summary>
        ///     Pops all but the root Page off the navigation stack.
        /// </summary>
        public async Task PopToRootAsync()
        {
            IScenePage top = null;
            IScenePage res = null;
            lock (_gate)
            {
                while (_stack.Count > 1) _stack.Pop();

                if (_stack.Count > 0) top = _stack.Peek();
            }

            await _container.SetCurrentPageAsync(top);
        }

        /// <summary>
        ///     Presents a Page modally.
        /// </summary>
        public async Task PushAsync(IScenePage page)
        {
            lock (_gate)
            {
                if (_stack.Count > 0)
                    if (_stack.Peek() == page)
                        return;
                _stack.Push(page);
            }

            await _container.SetCurrentPageAsync(page);
        }
    }
}