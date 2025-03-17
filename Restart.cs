using System.Numerics;
using System.Security.Cryptography.X509Certificates;


// GameController.cs
namespace MohawkGame2D
{
    public class Restartgame
    {
        // Constructor
        public Restartgame(bool gameOver = false)
        {
           Game.isGameOver = gameOver;  // Game starts as not over
        }
        public static void CheckRestart()
        {
            // Check if game is over
            if (Game.isGameOver)
            { // If game is over
                if (Input.IsKeyboardKeyPressed(KeyboardInput.R))
                {
                    // Restart the game 
                    Game.playerX = 50; // Set player X position
                    Game.playerY = 350; // Set player Y position
                    Game.isGameOver = false; // Set game over to false
                } 
                
                
                
            }
        }
        
            
            
                
                
                    
                
            
        
    }
}