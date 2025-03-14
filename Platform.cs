using System;
using System.Numerics;


namespace MohawkGame2D
{
    public class Platform
    {
        public float X { get; set; } // X position of the platform
        public float Y { get; set; } // Y position of the platform
        public float Width { get; } // Width of the platform
        public float Height { get; } // Height of the platform
        public Texture2D Texture { get; } // Texture of the platform

        // Constructor that takes a Texture2D to set up the platform.
        public Platform(float x, float y, Texture2D texture) // Constructor
        {
            X = x; // Set X position
            Y = y; // Set Y position
            Width = texture.Width; // Set Width
            Height = texture.Height; // Set Height
            Texture = texture; // Set Texture
        }
    }
}