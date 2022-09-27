using System;

namespace CuteAnimal
{
    public class Cat
    {
        private int energy;

        private Random rng;
        public string Name { get; }

        private Feed feed;
        private Mood mood;

        public Cat(int energy, string name, Feed feed, Mood mood) : this()
        {
            this.energy = energy;
            Name = name;
            this.feed = feed;
            this.mood = mood;
        }

        public Cat(string name) : this(40, name, Feed.AboutToExplode, Mood.Happy) { }

        public Cat()
        {
            rng = new Random();
        }

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