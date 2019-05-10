using System;

namespace Class15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Make a move person (0|Rock, 1|Paper, 2|Scissor): ");
            var response = Console.ReadLine();

            //var move = int.Parse(response);
            //Turn((Move)move);

            //if (int.TryParse(response, out int move))
            //{
            //    Turn((Move)move);
            //}

            //Enum.Parse(typeof(Move), response);
            //var move = Enum.Parse<Move>(response);
            //Turn(move);

            if (Enum.TryParse<Move>(response, true, out var move))
            {
                Turn(move);
            }
            else
            {
                Console.WriteLine("You done messed up A-Aron");
            }
        }

        public static void Turn(Move move)
        {
            //if (move == Move.Rock)
            //{
            //    Console.WriteLine("Welcome to the Rock!");
            //}
            //else if (move == Move.Paper)
            //{
            //    Console.WriteLine("Paaaaaaper!");
            //}
            //else if (move == Move.Scissor)
            //{
            //    Console.WriteLine("Scissors");
            //}

            Console.WriteLine("Before switch");
            switch (move)
            {
                case Move.Rock:
                    Console.WriteLine("Welcome to the Rock!");
                    break;
                case Move.Paper:
                    Console.WriteLine("Paaaaaaper!");
                    break;
                case Move.Scissor:
                    Console.WriteLine("Scissors");
                    break;
                default:
                    Console.WriteLine("I'm not sure what you are doing!!!");
                    break;
            }
            Console.WriteLine("After switch");
        }
    }
}
