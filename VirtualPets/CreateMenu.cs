using System;
using System.Collections.Generic;
using System.Threading;

namespace VirtualPets
{
    public class CreateMenu
    {

        public static void BuildCreateMenu()
        {
            var options = CreateMenu.MenuOptions();
            CreateMenu.DisplayMenu(options);
            CreateMenu.MenuSelection();
        }


        public static string menuTitle = @"
 #####                                               ######               
#     # #####  ######   ##   ##### ######     ##     #     # ###### ##### 
#       #    # #       #  #    #   #         #  #    #     # #        #   
#       #    # #####  #    #   #   #####    #    #   ######  #####    #   
#       #####  #      ######   #   #        ######   #       #        #   
#     # #   #  #      #    #   #   #        #    #   #       #        #   
 #####  #    # ###### #    #   #   ######   #    #   #       ######   # 
";

        public static List<string> MenuOptions()
        {
            return new List<string>
            {
                "Dog",
                "Cat",
                "Go Back"
            };

        }

        public static void DisplayMenu(List<string> MenuOptions)
        {
            Console.Clear();
            Console.WriteLine(menuTitle);
            Console.WriteLine("What kind of pet do you want to create?");
            Console.WriteLine("Enter the number of the option you want to select.");

            int optionNum = 1;
            foreach (var option in MenuOptions)
            {
                Console.WriteLine($"{optionNum++}. {option}");
            }
        }

        public static void MenuSelection()
        {
            var continueGame= true;
            do
            {
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice))
                {
                    if (numChoice == 3)
                    {
                        continueGame = false;
                    }
                    else
                    {
                        switch (numChoice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine(menuTitle);
                                // grab variables to create new dog
                                Console.WriteLine("What do you want to name your dog?");
                                var dogName = Console.ReadLine();
                                var dog = new Dog(dogName);
                                Console.WriteLine($"Congrats! You now have a dog named, {dog.Name}. Below are your dog's stats. Hit enter to continue to the next screen.");
                                dog.PrintStats();
                                Console.ReadLine();
                                DogActionMenu.BuildDogActionMenu(dog);
                                return;
                            case 2:
                                Console.Clear();
                                Console.WriteLine(menuTitle);
                                // grab variables to create new cat
                                Console.WriteLine("What do you want to name your cat?");
                                var catName = Console.ReadLine();
                                var cat = new Cat(catName);
                                Console.WriteLine($"Congrats! You now have a cat named, {cat.Name}. Below are your cat's stats. Hit enter to continue to the next screen.");
                                cat.PrintStats();
                                Console.ReadLine();
                                // initiate cat action loop
                                CatActionMenu.BuildCatActionMenu(cat);
                                return;
                            default:
                                // not sure what to do here
                                Console.WriteLine("Sorry, that was not valid. Please hit enter to try again.");
                                Console.ReadLine();
                                break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid option. Please hit enter to try again.");
                    Console.ReadLine();
                }
            }
            while (continueGame);
        }
    }
}
