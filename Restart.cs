using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GameController.cs
namespace MohawkGame2D
{
    public class Restart
    {
        public bool IsGameOver { get; set; }

        // Constructor
        public Restart()
        {
            IsGameOver = false;  // Game starts as not over
        }

        // Method to check if "R" key is pressed to restart the game
        public void CheckRestart()
        {
            if (Input.IsKeyboardKeyDown(KeyboardInput.R))  // Check if R key is pressed
            {
                RestartGame();  // Restart the game if R is pressed
            }
        }

        // Method to reset the game
        public void RestartGame()
        {
            IsGameOver = false;  // Set the game state to not over
                                 
        
            



        }
    }
}