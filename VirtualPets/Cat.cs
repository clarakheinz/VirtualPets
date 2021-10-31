using System;
namespace VirtualPets
{
    public class Cat : VirtualPet
    {
        public Cat(string name)
        {

            Name = name;
            PetType = "cat";
            DateCreated = DateTime.Today;
            Happiness = 50;
            
        }
    }
}
