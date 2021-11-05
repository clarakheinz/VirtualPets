using System;
namespace VirtualPets
{
    public class Cat : VirtualPet
    {

        public Cat() { }
        public Cat(string name)
        {

            Name = name;
            DateCreated = DateTime.Today;
            PetType = this.GetType().ToString();
            Happiness = 50;
            
        }

        // TODO: overload constructor method to allow for loading saved data into an instance of obj
    }
}
