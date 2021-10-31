using System;
using System.Collections.Generic;

namespace VirtualPets
{
    public class DogActionMenu
    {
        public static void BuildDogActionMenu()
        {
            var options = DogActionMenu.MenuOptions();
            DogActionMenu.DisplayMenu(options);
            DogActionMenu.MenuSelection();

        }

        public static string menuTitle = @"
######                 ######                        #######                 
#     # ###### #####   #     # #        ##   #   #      #    # #    # ###### 
#     # #        #     #     # #       #  #   # #       #    # ##  ## #      
######  #####    #     ######  #      #    #   #        #    # # ## # #####  
#       #        #     #       #      ######   #        #    # #    # #      
#       #        #     #       #      #    #   #        #    # #    # #      
#       ######   #     #       ###### #    #   #        #    # #    # ######
            ";

        public static List<string> MenuOptions()
        {
            return new List<string>
            {
                "Pet",
                "Play",
                "Feed",
                "Walk",
                "Save",
                "Exit"
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
            do
            {
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice))
                {

                    switch (numChoice)
                    {
                        case 1:
                            Console.Clear();
                            // call petObject.Pet();
                            Console.WriteLine("You pet the dog");
                            break;
                        case 2:
                            Console.Clear();
                            // call petObject.Play
                            Console.WriteLine("You played with the dog");
                            break;
                        case 3:
                            // call petObject.Feed()
                            Console.WriteLine("You fed the dog");
                            break;
                        case 4:
                            // call petObject.Walk()
                            Console.WriteLine("You walked the dog");
                            break;
                        case 5:
                            // call save method
                            break;
                        case 6:
                            // exit to main menu
                            Console.Clear();
                            Console.WriteLine("You're exiting to the main menu. I hope you saved!");
                            MainMenu.BuildMainMenu();
                            break;
                        default:
                            // not sure what to do here
                            BuildDogActionMenu();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid option. Please Try again.");
                }
            }
            while (true);
        }
    }
}
