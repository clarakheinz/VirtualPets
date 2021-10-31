using System;
using System.Collections.Generic;

namespace VirtualPets
{
    public class CatActionMenu 
    {
        public static void BuildCatActionMenu()
        {
            var options = CatActionMenu.MenuOptions();
            CatActionMenu.DisplayMenu(options);
            CatActionMenu.MenuSelection();
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
                            Console.WriteLine("You pet the cat");
                            break;
                        case 2:
                            Console.Clear();
                            // call petObject.Play
                            Console.WriteLine("You played with the cat");
                            break;
                        case 3:
                            // call petObject.Feed()
                            Console.WriteLine("You fed the cat");
                            break;
                        case 4:
                            // call save method
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine("You're exiting to the main menu. I hope you saved!");
                            MainMenu.BuildMainMenu();
                            break;
                        default:
                            // not sure what to do here
                            Console.Clear();
                            BuildCatActionMenu();
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
