namespace Class15.Recapulation
{
    public class Dinosaur : Animal
    {
        public int Age { get; set; }

        public Dinosaur(int age)
        {
            Age = age;
        }

        public string Rawr()
        {
            return Rawr("Something");
        }

        public string Rawr(string rawr)
        {
            return "roooooooooooooooooooooooooooooooooooooooooooar " + rawr;
        }

        public override string SaySomething()
        {
            return "Something";
        }
    }
}
