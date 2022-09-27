namespace CuteAnimal
{
    public class Cat
    {
        private int energy;
        private string name;

        private Feed feedStatus;
        private Mood moodStatus;

        public Cat(int energy, string name, Feed feedStatus, Mood moodStatus)
        {
            this.energy = energy;
            this.name = name;
            this.feedStatus = feedStatus;
            this.moodStatus = moodStatus;
        }

        public void Eat()
        {
            if (feedStatus < Feed.AboutToExplode)
            {
                feedStatus++;
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