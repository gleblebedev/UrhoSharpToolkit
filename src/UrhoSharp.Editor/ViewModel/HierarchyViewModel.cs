using System;
using GalaSoft.MvvmLight;
using UrhoSharp.Editor.Model;
using UrhoSharp.Prefabs;

namespace UrhoSharp.Editor.ViewModel
{
    public class HierarchyViewModel : ViewModelBase, IObserver<SceneChangeEventArgs>
    {
        private readonly InspectorViewModel _inspector;
        private NodeViewModel[] _root;
        private NodeViewModel _selectedNode;

        public HierarchyViewModel(InspectorViewModel inspector)
        {
            _inspector = inspector;
        }

        public NodeViewModel[] Root
        {
            get => _root;
            set => Set(ref _root, value);
        }

        public NodeViewModel SelectedNode
        {
            get => _selectedNode;
            set
            {
                if (Set(ref _selectedNode, value)) UpdateInspector(_selectedNode);
            }
        }


        public void OnNext(SceneChangeEventArgs value)
        {
            switch (value.ChangeType)
            {
                case SceneChangeEventArgs.Change.SceneReplaced:
                    ResetTree(value.Scene);
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

        private void UpdateInspector(NodeViewModel selectedNode)
        {
            _inspector.ValueViewModel = selectedNode;
        }

        private void ResetTree(ScenePrefab scene)
        {
            if (scene != null)
                Root = new[] {new NodeViewModel(scene)};
            //else
            //    Root = null;
        }
    }
}