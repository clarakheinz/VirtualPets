using System;
namespace VirtualPets
{
    public class Dog : VirtualPet
    {
        public Dog() { }
        public Dog(string name)
        {
            Name = name;
            DateCreated = DateTime.Today;
            PetType = this.GetType().ToString();
            Happiness = 50;
        }

        // TODO: Overload constructor method to allow for loading saved data

        public void Walk()
        {
            //walk your dog
            Console.WriteLine($"You walked {Name}!");
            Console.WriteLine($"What a happy and tired {PetType.Substring(PetType.Length -3).ToLower()}.");
            Calc_Happiness("walk");
        }
    }
}
