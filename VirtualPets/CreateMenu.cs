using System;
using System.Collections.Generic;

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
            do
            {
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice))
                {
                    if (numChoice == 3)
                    {
                        MainMenu.BuildMainMenu();
                    }
                    else
                    {
                        switch (numChoice)
                        {
                            case 1:
                                Console.Clear();
                                // grab variables to create new dog
                                break;
                            case 2:
                                Console.Clear();
                                // grab variables to create new cat

                                // initiate cat action loop
                                CatActionMenu.BuildCatActionMenu();
                                break;
                            default:
                                // not sure what to do here
                                BuildCreateMenu();
                                break;
                        }

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
