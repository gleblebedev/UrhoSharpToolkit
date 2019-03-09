using System;
using Urho;
using UrhoSharp.Prefabs;

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

        public ScenePrefab Scene { get; set; }
        public NodePrefab Node { get; set; }
        public IPrefab Component { get; set; }

        public static SceneChangeEventArgs NewScene(Scene scene)
        {
            return new SceneChangeEventArgs(Change.SceneReplaced)
            {
                Scene = scene == null ? null : new ScenePrefab(scene)
            };
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