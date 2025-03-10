// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
// The namespace your code is in.
namespace MohawkGame2D;
/// <summary>
///     Your game code goes inside this class!
/// </summary>
public class Game
{
    float playerX = 50;
    float playerY = 350;
    float playerSpeed = 5f;
    float DeltaTime = 5f;   

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()

    {
        Window.SetTitle("Blair's 2D Game");//Set Title
        Window.SetSize(500, 500);//Set Window Size
        Window.TargetFPS = 60;//Set Target FPS
    }




    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        //insert Background Image
        Window.ClearBackground(Color.Clear);
        Texture2D bg = Graphics.LoadTexture("C:.\\image001.png");
        Graphics.Scale = 1.3f;
        Graphics.Draw(bg, 0, 0);
        // Draw Rectangle as ground plane 

        // Draw a player graphic to the screen at position (200, 100).

        Texture2D player = Graphics.LoadTexture("C:.\\bear-walk1.png");// Load Player Image
        Texture2D player2 = Graphics.LoadTexture("C:.\\bear-walk3.png");// Load Player Image

        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                playerX -= playerSpeed;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                playerX += playerSpeed;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Up))
            {
                playerY -= playerSpeed;
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Down))
            {
                playerY += playerSpeed;
            }

            Graphics.Draw(player, playerX, playerY);// Draw Player Image
            Window.ClearBackground(Color.Clear);
            Graphics.Draw(player2, playerX, playerY);// Draw Player Image

        }



    }
}