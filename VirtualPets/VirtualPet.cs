using System;
namespace VirtualPets
{
    public class VirtualPet
    {

        // cat and dog will inherit from this class
        private string name;
        private string pet_type;
        private string gender;
        private static DateTime datecreated;
        private int age;
        private int happiness;

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

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public DateTime DateCreated
        {
            get { return datecreated; } // set at instance with the 
        }

        public int Age
        {
            get { return age; }
            set { age = Calc_Age(); } //build this method
        }

        //public int Happiness
        //{
        //    get { return happiness; }
        //    set { happiness = Calc_Happiness(); }
        //}

        public static int Calc_Age()
        {
            DateTime today = DateTime.Now;
            TimeSpan spanAge =  VirtualPet.datecreated - today;
            return spanAge.Days;
        }

        //public static int Calc_Happiness(); // to build out

        //public void Pet() { } //pet your pet
        //public void Play() { } //play with pet
        //public void Feed() { } //feed pet

        //constructor
    }
}
