using System;

namespace UrhoSharp.Editor.Model
{
    public class AssetFileEventArgs : EventArgs
    {
        public enum ChangeTypes
        {
            Created,
            Changed,
            Deleted
        }

        public AssetFileEventArgs(ChangeTypes changeType, string fullPath, string resourceName)
        {
            ChangeType = changeType;
            FullPath = fullPath;
            ResourceName = resourceName;
        }

        public ChangeTypes ChangeType { get; }

        public string ResourceName { get; }

        public string FullPath { get; }
    }
}