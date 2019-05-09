using System;

namespace Class14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engine dieselEngine = new DieselEngine();
            //dieselEngine.Drive();

            //var car = new Car();
            //HonkSomething(car);

            Console.Write("Hey buddy, do you know how fast you were going?");
            var speed = Console.ReadLine();

            var truck = new Truck();
            truck.EngageFourWheel();
            truck.Drive(speed);
            HonkSomething(truck);
        }

        public static void HonkSomething(IHonk honk)
        {
            // Cannot do this - honk.EngageFourWheel();
            Console.WriteLine(honk.Honk());
        }
    }
}
