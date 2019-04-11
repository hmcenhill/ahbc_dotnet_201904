using System;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nested loops
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (i == 2 && j == 0)
                    {
                        continue;
                    }

                    Console.WriteLine($"{i} x {j}");
                }
            }

            // Scope example
            int x = 0;
            if (true)
            {
                int y = 0;
            }

            if (true)
            {
                int y = 3;
            }

            // continue and break statements

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    // break;
                    continue;
                }

                Console.WriteLine(i);
            }



            Console.ReadKey();
        }
    }
}

