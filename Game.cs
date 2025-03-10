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
    float playerSpeed = 7f;
    float DeltaTime = 5f;
    int currentFrame = 0; // Current Frame
    float frameTime = 5f; // Time per Frame
    float frameTimer = 0f; // Timer for Frame

    int windowWidth = 500;
    int windowHeight = 500;

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()

    {
        Window.SetTitle("Blair's 2D Game");//Set Title
        Window.SetSize(500, 500);//Set Window Size
        Window.TargetFPS = 30;//Set Target FPS
    }
    /// <summary>
    ///     Update runs every frame.
    /// </summary>
    public void Update()
    {
        //insert Background Image

        Texture2D bg = Graphics.LoadTexture("C:.\\image001.png");
        Graphics.Scale = 1.3f; // Scale Background Image
        Graphics.Draw(bg, 0, 0);
        // Draw Rectangle as ground plane 

        // Draw a player graphic to the screen at position (200, 100).

        Texture2D player = Graphics.LoadTexture("C:.\\bear-walk1.png");// Load Player Image
        Texture2D player2 = Graphics.LoadTexture("C:.\\bear-walk2.png");// Load Player Image
        Texture2D player3 = Graphics.LoadTexture("C:.\\bear-walk3.png");// Load Player Image
        Texture2D player4 = Graphics.LoadTexture("C:.\\bear-walk4.png");// Load Player Image


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

            //
            frameTimer += DeltaTime; // Add DeltaTime to FrameTimer

            if (frameTimer >= frameTime)
            {
                frameTimer = 0; // Reset FrameTimer
                currentFrame++; // Change Frame
                

                if (currentFrame > 3) 
                {

                    currentFrame = 0;
                }
                // if player goes beyond the screen, wrap around
                if (playerX > Window.Width)
                {
                    playerX = 0;
                }
                else if (playerX < 0)
                {
                    playerX = Window.Width;
                }
                Texture2D currentPlayerTexture = currentFrame switch// Switch Statement for Current Frame
                 { 
                    0 => player, //
                    1 => player2,
                    2 => player3,
                    3 => player4,
                    _ => player
                };

                Graphics.Draw(currentPlayerTexture, playerX, playerY);// Draw Player Image
                Window.ClearBackground(Color.Clear);


            } }



    }
}