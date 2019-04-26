using System;

namespace Class9
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = MathHelper.Sum(5, 6);

            var meeko = new Animal("Meeko");
            meeko.SetName("Litter Pooper");

            var lizzy = new Animal("Lizzy");
            //lizzy.SetName("Lizzy");
                        
            Console.WriteLine(meeko.GetName());
            Console.WriteLine(lizzy.GetName());
            
            Console.ReadLine();
        }
    }
}
