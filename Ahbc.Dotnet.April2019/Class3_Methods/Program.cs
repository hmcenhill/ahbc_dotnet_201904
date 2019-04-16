using System;

namespace Class3_Methods
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Step 1: Initialize Variable, ie. int i = 0;
            // Step 2: Check our Boolean Statement is true, ie. i < 10;
            //  If false, For loop ends, no more for loop.... get outta here

            // step 4: Incrementor or decrementor, ie. i++

            // step 5: repeat step 2
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    // step 3: Run the code in this block
            //}
            //             0 = J, 1 = a, 2 = m, 3 = e, 4 =s
            //string name = "James";
            //for (int i = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //    // step 3: Run the code in this block
            //}

            // Our first function... YAAAY!

            //int input1 = int.Parse(Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());


            //int result = AddTwoNumbers(2, 3);
            //int result2 = AddTwoNumbers(input1, input2);
            //Console.WriteLine(result);
            //Console.ReadLine();

            // Class helps me make a function, WOOT WOOT

            //int returnedSubtratedNumber = SubtractTwoNumbers(8, 5);
            //Console.WriteLine(returnedSubtratedNumber);
            //Console.ReadLine();

            // Class helps again tee hee :)

            //bool isOldEnough = IsOldEnoughToDrink(21);
            //Console.WriteLine(isOldEnough);
            //Console.ReadLine();


            //PrintMessage("Hey guys lol");

            // CLASS EXAMPLE

            // PrintToScreenThisManyTimes(8);

            //var result = (float)AddNumbers(1.1f, 2.1f);


            // PASS BY REF

            //int number = 5;
            //// PassIntByReference(ref refInt);
            //PassInt(number);
            //PassInt(number);
            //PassInt(number);
            //PassInt(number);
            //PassInt(number);
            //PassInt(number);

            // CLASS FIGURES MORE THINGS OUT

            int length = GetStringLength("SUP, THIS IS MY TOTALLY COOL EXAMPLE, I WILL GET THE LENGTH OF THIS" +
                "VERY LONG STRING HEH, LOL... OKAY");

            Console.WriteLine(length);
            Console.ReadLine();

        }


        static void PassIntByReference(ref int a)
        { 
            a++;
        }

        static void PassInt(int a)
        {
            if (a < 0)
            {
                a++;
            }
            else
            {
                a--;
            }
        }

        static void PassStringByRefernce(ref string word)
        {
            
        }
        

        static void PassArrayByReference(ref int[] arry)
        {
            return;
        }
        static float AddFloats(float a, float b)
        {
            return a + b;
        }

        /// <summary>
        /// return 1 + 1
        /// </summary>
        /// <returns></returns>
        static int AddNumbers()
        {
            return 1 + 1;
        }

        /// <summary>
        /// Add the ONE number you are passing in, into itslself, example, a = 5, 5 + 5;
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int AddNumbers(int a)
        {
            return a + a;
        }

        /// <summary>
        /// Add numbers together lol
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int AddNumbers(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        /// <summary>
        /// Add numbers together lol
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int AddNumbers(float a, float b)
        {
            var sum = a + b;
            return (int)sum;
        }

        /// <summary>
        /// Add THREE numbers together
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int AddNumbers(int a, int b, int c)
        {
            return a + b + c;
        }

        /// <summary>
        /// Add FOUR numbers together!
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        static int AddNumbers(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        static int SubtractTwoNumbers(int a, int b)
        {
            int subtractedTotal = a - b;
            return SubtractTwoNumbers(subtractedTotal, b);
        }

        static bool IsOldEnoughToDrink(int age)
        {
            if (age >= 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        

        static void PrintToScreenThisManyTimes(int a)
        {
            if  (a <= 0)
            {
                Console.WriteLine("give me a larger number please tee hee :)");
               //  return;
            }

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(i);
            }

        }

        static int GetStringLength(string word)
        {
            return word.Length;
        }
    }
}
