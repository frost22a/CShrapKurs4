using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.PlayGame();
            Console.WriteLine("Game Over!");
        }
    }
}
