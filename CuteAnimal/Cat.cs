namespace CuteAnimal
{
    public class Cat
    {
        private int energy;
        private string name;

        private Feed feedStatus;
        private Mood moodStatus;


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
            if (energy == 100)
            {

            }
        }

        public void Play()
        {

        }

        public void Meow()
        {

        }
    }
}