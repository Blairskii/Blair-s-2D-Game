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
    //
    int windowWidth = 500; // Window Width
    int windowHeight = 500;// Window Height

    //Gravity
    float gravity = 0.5f;// Gravity
    float jumpStrength = 10f;// Jump Strength
    float yVelocity = 0f;// Y Velocity
    bool isJumping = false;// Is Jumping
    bool isGrounded = false;// Is Grounded

    /// <summary>
    ///     Setup runs once before the game loop begins.
    /// </summary>
    public void Setup()

    {
        Window.SetTitle("Blair's 2D Game");//Set Title
        Window.SetSize(500, 500);//Set Window Size
        Window.TargetFPS = 20;//Set Target FPS
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
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))// If Left Arrow is Pressed
            {
                playerX -= playerSpeed;// Move Player Left
            }
            else if (Input.IsKeyboardKeyDown(KeyboardInput.Right))// If Right Arrow is Pressed
            {
                playerX += playerSpeed;// Move Player Right
            }
            
            if (isGrounded)
            {
                if (Input.IsKeyboardKeyDown(KeyboardInput.Space))// If Space is Pressed
                {
                    
                    
                        yVelocity = -jumpStrength;// Add Jump Strength to Y Velocity
                    isJumping = true;// Set isJumping to True
                    isGrounded = false;// Set isGrounded to False

                }
            }
            if (!isGrounded) // If Player is not Grounded
            {
                playerY += yVelocity; // Add Y Velocity to Player Y
            }
            {
                yVelocity += gravity;// Add Gravity to Y Velocity
            }
            if (playerY >= 350)// If Player Y is greater than or equal to 350
            {
                playerY = 350;
                isJumping = false;
                isGrounded = true;
                yVelocity = 0;
            }
            //
            frameTimer += DeltaTime; // Add DeltaTime to FrameTimer

            if (frameTimer >= frameTime)
            {
                frameTimer = 0; // Reset FrameTimer
                currentFrame++; // Change Frame
                

                if (currentFrame > 3) // If Current Frame is greater than 3
                {

                    currentFrame = 0;// Reset Current Frame
                }
                // if player goes beyond the screen, wrap around
                if (playerX > Window.Width) // If Player X is greater than Window Width
                {
                    playerX = 0; // Reset Player X
                }
                else if (playerX < 0) // If Player X is less than 0
                {
                    playerX = Window.Width; // Reset Player X
                }
                Texture2D currentPlayerTexture = currentFrame switch// Switch Statement for Current Frame
                 { 
                    0 => player, // Frame 1 
                    1 => player2,// Frame 2
                    2 => player3,// Frame 3
                    3 => player4,// Frame 4
                     _ => player // Default 
                 };

                Graphics.Draw(currentPlayerTexture, playerX, playerY);// Draw Player Image
                Window.ClearBackground(Color.Clear);// Clear Background


            } }



    }
}