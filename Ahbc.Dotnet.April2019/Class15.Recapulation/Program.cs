using System;

namespace Class15.Recapulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var dinosaur = new Dinosaur(500);
            
            Console.WriteLine($"Hello I am George a {dinosaur.Age} year old dinosaur");

            //Console.WriteLine(dinosaur.Rawr("Huuuungry"));
            var output = dinosaur.Rawr("Huuuungry");
            Console.WriteLine(output);
            
            Console.WriteLine(dinosaur.Rawr());

            Animal animal = new Dinosaur(600);
            animal.SaySomething();
            dinosaur.SaySomething();

            Animal sloth = new Sloth();
            DoTheDeed(sloth);
            DoTheDeed(animal);

            sloth.DoSomething();
            dinosaur.DoSomething();
        }

        public static void DoTheDeed(Animal animal)
        {
            animal.DoSomething();
            Console.WriteLine(animal.SaySomething());
        }
    }
}
