using System;

namespace UrhoSharp.Interfaces
{
    [Flags]
    public enum HatPosition
    {
        None,
        Up = 1,
        Right = 2,
        Down = 4,
        Left = 8,
        UpRight = Up | Right,
        DownRight = Down | Right,
        UpLeft = Up | Left,
        DownLeft = Down | Left
    }
}