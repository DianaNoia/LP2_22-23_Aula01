using System;

namespace CuteAnimal
{
    public class Cat
    {
        private int energy;
        private string name;

        private Random rng;

        private Feed feed;
        private Mood mood;

        public Cat(int energy, string name, Feed feed, Mood mood) : this()
        {
            this.energy = energy;
            this.name = name;
            this.feed = feed;
            this.mood = mood;
        }

        public Cat(string name) : this(40, name, Feed.AboutToExplode, Mood.Happy) { }

        public Cat()
        {
            rng = new Random();
        }

        public string GetName() => name;

        public void Eat()
        {
            if (feed < Feed.AboutToExplode)
            {
                feed++;
            }
        }

        public void Sleep()
        {
            energy += 20;

        }

        public void Play()
        {

        }

        public void Meow()
        {

        }
    }
}