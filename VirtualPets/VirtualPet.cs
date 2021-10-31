using System;
namespace VirtualPets
{
    public class VirtualPet
    {


        // cat and dog will inherit from this class
        private string name;
        private string pet_type;
        private static DateTime datecreated;
        private int age;
        private static int happiness;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PetType
        {
            get { return pet_type; }
            set { pet_type = value; }
        }

        public DateTime DateCreated
        {
            get;
            init; // set at instance with the constructor
        }

        public int Age
        {
            get { return age; }
            set { age = Calc_Age(); } //build this method
        }

        public static int Happiness
        {
            get { return happiness; }
            set { happiness = value; }
        }

        public static int Calc_Age()
        {
            DateTime today = DateTime.Now;
            TimeSpan spanAge = datecreated - today;
            return spanAge.Days;
        }

        public void PrintStats()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Date Created: {DateCreated.Date}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Pet Type: {PetType}");
            Console.WriteLine($"Happiness: {Happiness}");
        }

        public static int Calc_Happiness(string action)
        {
            switch (action)
            {
                case "pet" or "play":
                    
                    return (int)(Happiness * 1.3);
;
                case "feed" or "walk":
                    return (int)(Happiness * 1.5);
                case "nothing":
                    return (int)(Happiness * .8);
                default:
                    return Happiness;
            }

        } 

        public void Pet()
        {
            //pet your pet
            Console.WriteLine($"You pet {Name}!");
            Console.WriteLine($"What a good {PetType}.");
            Calc_Happiness("pet");
        }
        public void Play()
        {
            //play with pet
            Console.WriteLine($"You played with {Name}!");
            Console.WriteLine($"What a happy {PetType}.");
            Calc_Happiness("play");
        }
        public void Feed()
        {
            //feed pet
            Console.WriteLine($"You fed {Name}!");
            Console.WriteLine($"What a pleased and full {PetType}.");
            Calc_Happiness("feed");
        }

        public void DoNothing()
        {
            // do nothing with pet
            Console.WriteLine($"You decided to do nothing with {Name}.");
            Calc_Happiness("nothing");
        }

    }
}
