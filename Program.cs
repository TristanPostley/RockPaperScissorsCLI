using System;

namespace RockPaperScissorsCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Player 1 make selection");
            Console.WriteLine("[r]");
            Console.WriteLine("[p]");
            Console.WriteLine("[s]");
            string p1Input = Console.ReadLine();

            Console.WriteLine("Player 2 make selection");
            Console.WriteLine("[r]");
            Console.WriteLine("[p]");
            Console.WriteLine("[s]");
            string p2Input = Console.ReadLine();

            game(p1Input, p2Input);

        }

        public static void game(string p1Input, string p2Input)
        {
            if(p1Input == p2Input) Console.WriteLine("Tie");
            else if(p1Input == "r" && p2Input == "p") Console.WriteLine("Player 2 Wins");
            else if(p1Input == "r" && p2Input == "s") Console.WriteLine("Player 1 Wins");
            else if(p1Input == "p" && p2Input == "r") Console.WriteLine("Player 1 Wins");
            else if(p1Input == "p" && p2Input == "s") Console.WriteLine("Player 2 Wins");
            else if(p1Input == "s" && p2Input == "r") Console.WriteLine("Player 2 Wins");
            else if(p1Input == "s" && p2Input == "p") Console.WriteLine("Player 1 Wins");
            else Console.WriteLine("Invalid Input");

        }
    }
}
