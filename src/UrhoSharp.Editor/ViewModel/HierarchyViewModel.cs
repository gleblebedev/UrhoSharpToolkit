using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;

namespace UrhoSharp.Editor.ViewModel
{
    public class HierarchyViewModel:ViewModelBase, IObserver<SceneChangeEventArgs>
    {

        public void OnNext(SceneChangeEventArgs value)
        {
            switch (value.ChangeType)
            {
                case SceneChangeEventArgs.Change.SceneReplaced:
                    break;
                case SceneChangeEventArgs.Change.NodeAdded:
                    break;
                case SceneChangeEventArgs.Change.ComponentAdded:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public void OnError(Exception error)
        {
        }

        public void OnCompleted()
        {
        }
    }
}
