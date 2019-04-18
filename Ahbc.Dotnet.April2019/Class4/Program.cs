using System;
using System.Text.RegularExpressions;

namespace Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Entering and parsing an integer

            //var again = true;
            //while (again)
            //{
            //    Console.Write("Give me a number (x to quit): ");
            //    var response = Console.ReadLine();
            //    if (response.Equals("x", StringComparison.OrdinalIgnoreCase))
            //    {
            //        again = false;
            //    }
            //    else
            //    {
            //        var number = int.Parse(response);
            //        Console.WriteLine($"You entered - {number}");
            //    }
            //}

            //// Catching the exception

            //Console.Write("Give me a number (x to quit): ");
            //var response = Console.ReadLine();

            //var number = 0;
            //try
            //{
            //    number = int.Parse(response);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("This will always catch!");
            //}

            //Console.WriteLine($"You entered - {number}");
            //Console.ReadLine();

            //// The best way to handle exceptions... is to avoid them!

            //Console.Write("Give me a number (x to quit): ");
            //var response = Console.ReadLine();

            //int number = 0;
            //if(int.TryParse(response, out number))
            //{
            //    Console.WriteLine($"You entered - {number}");
            //}
            //else
            //{
            //    Console.WriteLine("You didn't enter a number");
            //}

            ///////////////////////

            //var input = "Hello";

            //string lower;
            //var result = IsLowerCase(input, out lower);

            //Console.WriteLine($"Input = {input}, Result = {result}, Lower = {lower}");

            // Regular Expressions
            // https://regex101.com/

            Console.Write("Enter your SOC! Yeah, I'm serious! ");
            var input = Console.ReadLine();
            if (Regex.IsMatch(input, @"^\d{3}\-?\d{2}\-?\d{4}$"))
            {
                Console.WriteLine("Thank you! Sucker!");
            }
            else
            {
                Console.WriteLine("Seriously?!? Do IT!");
            }

            Console.ReadLine();
        }

        public static bool IsLowerCase(string input, out string lower)
        {
            lower = input.ToLower();

            return input == lower;
        }

    }
}
