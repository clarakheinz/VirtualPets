﻿using System;
namespace VirtualPets
{
    public class VirtualPet
    {

        // cat and dog will inherit from this class
        // add name, age, happiness attributes
        // happiness method?
        private string name;
        private string pet_type;
        private string gender;
        private DateTime datecreated;
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

        //need age and happiness

        public int Age
        {
            get { return age; }
            set { age = Calc_Age(); } //build this method
        }

        public int Happiness
        {
            get { return happiness; }
            set { happiness = Calc_Happiness(); }
        }

        public static Calc_Age();
        public static Calc_Happiness();

        public void Pet() { } //pet your pet
        public void Play() { } //play with pet
        public void Feed() { } //feed pet

        //constructor
    }
}
