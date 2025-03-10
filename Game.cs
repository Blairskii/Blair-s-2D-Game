// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using Raylib_cs;


// The namespace your code is in.
namespace MohawkGame2D;

/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()

    {
        Window.SetTitle("Blair's 2D Game");
        Window.SetSize(500, 500);
        Window.TargetFPS = 60;
    }

    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        Window.ClearBackground(Color.Clear);
        Texture2D bg = Graphics.LoadTexture("C:.\\image001.png");
        Graphics.Scale = 1.3f;
        Graphics.Draw(bg, 0, 0);
        

    }
}

