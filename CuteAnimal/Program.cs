using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat(50, "Leonor", Feed.Starving, Mood.Happy);
            Cat c2 = new Cat(10, "Faisca", Feed.Satisfied, Mood.Grumpy);
            Cat c3 = new Cat("Pincel");

            Console.WriteLine(c1.Name);
            Console.WriteLine(c2.Name);
            Console.WriteLine(c3.Name);
        }
    }
}
