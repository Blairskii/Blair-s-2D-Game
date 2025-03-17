using System.Numerics;


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
        public void CheckRestart()
        {
            if (IsGameOver)
            {
                if (Input.IsKeyboardKeyDown(KeyboardInput.R))
                {
                    IsGameOver = false;
                }
            }
        }
    }
}

 
                                 
        
            



        