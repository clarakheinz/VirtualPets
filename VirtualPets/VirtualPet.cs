using System;
using Newtonsoft.Json;

namespace VirtualPets
{
    public class VirtualPet
    {


        // cat and dog will inherit from this class
        private string name;
        private string pet_type;
        private static DateTime datecreated;
        //private int age;
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

        [JsonProperty("DateCreated")]
        public DateTime DateCreated
        {
            get { return datecreated; }
            set { datecreated = value; }
        }

        [JsonIgnore]
        public int Age => Calc_Age();

        [JsonProperty("Happiness")]
        public int Happiness
        {
            get { return happiness; }
            set { happiness = value; }
        }

        public static int Calc_Age()
        {
            DateTime today = DateTime.Now;
            TimeSpan spanAge =  today -  datecreated;
            return spanAge.Days;
        }

        public void PrintStats()
        {
            Console.WriteLine($"{Name}'s statistics:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Date Created: {DateCreated.Date.ToShortDateString()}");
            Console.WriteLine($"Age: {Age} days old");
            Console.WriteLine($"Pet Type: {PetType.ToString().Substring(PetType.ToString().Length - 3)}");
            Console.WriteLine($"Happiness: {Happiness} points");
        }

        public static void Calc_Happiness(string action)
        {
            switch (action)
            {
                case "pet" or "play":
                    
                    happiness = (int)(happiness * 1.25);
                    if (happiness < 0)
                    {
                        happiness = 0;
                    }
                    else if (happiness ==0)
                    {
                        happiness = 1;
                    }
                    break;
;
                case "feed" or "walk":
                    happiness =  (int)(happiness * 1.4);
                    if (happiness < 0)
                    {
                        happiness = 0;
                    }
                    else if (happiness > 100)
                    {
                        happiness = 100;
                    }
                    else if (happiness == 0)
                    {
                        happiness = 1;
                    }
                    break;
                case "nothing":
                    happiness = (int)(happiness * .8);
                    if (happiness < 0)
                    {
                        happiness = 0;
                    }
                    else if (happiness > 100)
                    {
                        happiness = 100;
                    }
                    break;
            }

        } 

        public void Pet()
        {
            //pet your pet
            Console.WriteLine($"You pet {Name}!");
            Console.WriteLine($"What a good {PetType.Substring(PetType.Length - 3).ToLower()}.\n");
            Calc_Happiness("pet");
        }
        public void Play()
        {
            //play with pet
            Console.WriteLine($"You played with {Name}!");
            Console.WriteLine($"What a happy {PetType.Substring(PetType.Length - 3).ToLower()}.\n");
            Calc_Happiness("play");
        }
        public void Feed()
        {
            //feed pet
            Console.WriteLine($"You fed {Name}!");
            Console.WriteLine($"What a pleased and full {PetType.Substring(PetType.Length - 3).ToLower()}.\n");
            Calc_Happiness("feed");
        }

        public void DoNothing()
        {
            // do nothing with pet
            Console.WriteLine($"You decided to do nothing with {Name}.\n");
            Calc_Happiness("nothing");
        }

    }
}
