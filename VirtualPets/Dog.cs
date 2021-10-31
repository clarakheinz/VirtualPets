using System;
namespace VirtualPets
{
    public class Dog : VirtualPet
    {
        public Dog(string name)
        {
            Name = name;
            PetType = "dog";
            DateCreated = DateTime.Today;
            Happiness = 50;
        }

        public void Walk()
        {
            //walk your dog
            Console.WriteLine($"You walked {Name}!");
            Console.WriteLine($"What a happy and tired {PetType}.");
            Calc_Happiness("walk");
        }
    }
}
