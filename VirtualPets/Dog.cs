using System;
namespace VirtualPets
{
    public class Dog : VirtualPet
    {
        public Dog()
        {
            /* rough draft of method
             * public void Walk()
            {
                int minsWalk;
                do
                {
                    Console.WriteLine("How many minutes would you like to walk your dog? (Enter a number greater than 0)");
                    string response = Console.ReadLine();
                    if (!int.TryParse(response, out minsWalk))
                    {
                        Console.WriteLine("I'm sorry, that was not a valid input. Please try again.");
                        response = Console.ReadLine();
                    }
                }
                while (minsWalk < 0);

                Console.WriteLine($"You've walked your dog {minsWalk} minutes!");
            } */
        }
    }
}
