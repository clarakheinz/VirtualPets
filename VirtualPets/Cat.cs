using System;
namespace VirtualPets
{
    public class Cat : VirtualPet
    {
        public Cat(string name)
        {

            Name = name;
            PetType = "cat";
            DateCreated = DateTime.Today.Date;
            Happiness = 50;
            
        }

        // TODO: overload constructor method to allow for loading saved data into an instance of obj
    }
}
