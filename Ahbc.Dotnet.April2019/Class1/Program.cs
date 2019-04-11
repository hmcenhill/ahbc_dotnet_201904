using System;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit cast
            int x = 56;
            long y = x;

            // explicit cast
            long z = 57;
            int w = (int)z;

            // parse
            string a = "56";
            int b = int.Parse(a);
            long c = long.Parse(a);

            // Relational operators
            Console.WriteLine(x == (y + 34 * 3 / 14));
            Console.WriteLine(x != int.Parse(a));
            Console.WriteLine(x > b);
            Console.WriteLine(x >= y);
            Console.WriteLine(x < y);
            Console.WriteLine(x <= y);

            // Logical Operators
            Console.WriteLine(x == y && x == b);
            Console.WriteLine(x == y || 1 == 0);

            bool jason = x == y;
            bool robert = !jason;

            // If statements
            if (x == y)
            {
                bool d = true;
                // Can access x here because scope allows it
                Console.WriteLine(x);
            }
            else if (x >= y)
            {
                Console.WriteLine("Hi Timothy!");
            }

            // Cannot access d because of scope and such - Console.WriteLine(d);

            // Switch Statements
            int e = 4;
            switch (e)
            {
                case 1:
                    Console.WriteLine("It is 1!");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("It is 2 or 3");
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Sorry, out of luck buddy");
                    break;
            }

            // While loop
            string input = "x";
            while (input != "x")
            {
                Console.WriteLine("Hello class");
                input = Console.ReadLine();
            }

            // Do loop
            string input2 = "x";
            do
            {
                Console.WriteLine("From a do loop dee loop");
                input2 = Console.ReadLine();
            } while (input2 != "x");

            // For loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
