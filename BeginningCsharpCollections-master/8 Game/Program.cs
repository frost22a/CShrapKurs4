using System;

namespace _8_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe ticTacToe = new TicTacToe();
            ticTacToe.PlayGame();
            Console.WriteLine("Game over");
        }
    }
}
