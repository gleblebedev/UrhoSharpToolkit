using System;
using Urho;

namespace UrhoSharp.Editor.Model
{
    public class SceneChangeEventArgs : EventArgs
    {
        public enum Change
        {
            SceneReplaced,
            NodeAdded,
            ComponentAdded
        }

        public SceneChangeEventArgs(Change type)
        {
            ChangeType = type;
        }

        public Change ChangeType { get; }

        public static SceneChangeEventArgs NewScene(Scene scene)
        {
            return new SceneChangeEventArgs(Change.SceneReplaced);
        }

        public static SceneChangeEventArgs ComponentAdded(ComponentAddedEventArgs args)
        {
            return new SceneChangeEventArgs(Change.ComponentAdded);
        }

        public static SceneChangeEventArgs NodeAdded(NodeAddedEventArgs args)
        {
            return new SceneChangeEventArgs(Change.NodeAdded);
        }
    }
}