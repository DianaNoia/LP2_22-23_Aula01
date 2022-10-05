using System;

namespace CuteAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar os gatos

            Cat c1, c2;

            // Alterar os valores comuns de todos os gatos
            Cat.MaxEnergy = 300;
            Cat.EnergyGainAfterSleep = 25;
            Cat.EnergyLossAfterMeow = 2;
            Cat.EnergyLossAfterPlay = 14;

            // Criar 2 gatos usando os diferentes construtores 

            c1 = new Cat("Faisca", 10, Feed.Satisfied, Mood.Grumpy);
            c2 = new Cat("Pincel");

            // Mostrar estado de cada gato antes das ações
            Console.WriteLine("Estado inicial dos gatos:");

            Console.WriteLine("\tNome={0}, Energia={1}, Alimentação={2}, Disposição={3}",
                c1.Name, c1.Energy, c1.FeedStatus, c1.MoodStatus);

            Console.WriteLine("\tNome={0}, Energia={1}, Alimentação={2}, Disposição={3}",
                c2.Name, c2.Energy, c2.FeedStatus, c2.MoodStatus);

            // Gato 1 brinca e mia
            Console.WriteLine($"{c1.Name} plays");
            c1.Play();
            c1.Meow();

            // Gato 2 come e dorme

            Console.WriteLine($"{c2.Name} eats and sleeps");
            c2.Eat();
            c2.Sleep();

            // Estado dos gatos após terem efetuado algumas ações
            Console.WriteLine("Estado final dos gatos, após as suas ações:");

            Console.WriteLine("\tNome={0}, Energia={1}, Alimentação={2}, Disposição={3}",
                c1.Name, c1.Energy, c1.FeedStatus, c1.MoodStatus);

            Console.WriteLine("\tNome={0}, Energia={1}, Alimentação={2}, Disposição={3}",
                c2.Name, c2.Energy, c2.FeedStatus, c2.MoodStatus);
        }
    }
}
