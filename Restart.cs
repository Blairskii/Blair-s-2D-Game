using System.Numerics;

namespace MohawkGame2D
{
    public class Restart
    {
        public bool IsGameOver { get; set; }

        // Constructor
        public Restart(bool gameOver = false)
        {
            IsGameOver = gameOver;  // Game starts as not over
        }

        // Method to check for restart input
        public void CheckRestart()
        {
            if (IsGameOver && KeyboardInput.IsKeyDown('R'))
            {
                IsGameOver = false;
            }
        }
    }

    // Keyboard Input Handling Class
    public static class KeyboardInput
    {
        public static bool IsKeyDown(char key)
        {
            // This is a placeholder. You can integrate this with Raylib or Unity's input system.
            return false;
        }
    }
}
