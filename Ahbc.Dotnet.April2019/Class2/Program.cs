using System;
using System.Text;

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

            // Triangle
            for (int a = 0; a < 10; a++)
            {
                for (int b = 10 - a; b > 0; b--)
                {
                    Console.Write(" ");
                }

                for (int c = 0; c < a; c++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
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

            // String creation
            var jason = new string('*', 5);
            Console.WriteLine(jason);
            
            string a1 = "Steak Sauce";
            a1 += "!!!";

            // String Concatenation
            string a2 = a1 + " Yummmm" + "!!!";
            string a3 = string.Concat(a1, " Yummm", "!!!");

            // String Formatting
            string a4 = $"{a1} Yummm !!!";
            string a5 = string.Format("{0} {1}!!!", a1, "Yummm");

            // String Comparison
            string a6 = "Jason Timoasdfasdfasdfasdfthy Robert ";
            string a7 = "jason robert";

            //Console.WriteLine(a6 == a7);
            //Console.WriteLine(a6.Equals(a7, StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(string.Compare(a6, a7));

            // More String Functions
            Console.WriteLine(a6.IndexOf('R', StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(a6.IndexOf("rob", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(a6.IndexOf('o', 5));
            Console.WriteLine(a6.LastIndexOf('o'));
            Console.WriteLine(a6.Substring(6, 7));
            Console.WriteLine(a6.Substring(a6.IndexOf(' ') + 1, a6.LastIndexOf(' ') - a6.IndexOf(' ')));
            Console.WriteLine(a6.EndsWith("t")); 
            Console.WriteLine(a6.Trim().TrimEnd('t').TrimStart().EndsWith("t"));

            // String immutability
            string name;
            name = "jason"; //jason
            name += " timothy"; // jason, jason timothy
            name += " robert"; // jason, jason timothy, jason timothy robert
            Console.WriteLine(name);

            StringBuilder builder = new StringBuilder();
            builder.Append(name);
            builder.Append("jason"); // jason
            builder.Append(" timothy"); // jason timothy
            builder.Append(" robert"); // jason timothy robert
            Console.WriteLine(builder.ToString()); // ties them all together

            Console.ReadLine();
        }
    }
}

