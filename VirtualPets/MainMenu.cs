using System;
using System.Collections.Generic;
using System.Threading;

namespace VirtualPets
{
    public class MainMenu
    {

        public static void BuildMainMenu()
        {
            var options = MainMenu.MenuOptions();
            MainMenu.MenuBuildAndSelection(options);

        }

        public static string GameTitle = @"
#     #                                       ######                      
#     # # #####  ##### #    #   ##   #        #     # ###### #####  ####  
#     # # #    #   #   #    #  #  #  #        #     # #        #   #      
#     # # #    #   #   #    # #    # #        ######  #####    #    ####  
 #   #  # #####    #   #    # ###### #        #       #        #        # 
  # #   # #   #    #   #    # #    # #        #       #        #   #    # 
   #    # #    #   #    ####  #    # ######   #       ######   #    #### 
";


        public static List<string> MenuOptions()
        {
            return new List<string>
            {
                "Create New Pet",
                "Load Pet",
                "Exit"
            };
        }

        public static void DisplayOptions(List<string> menuOptions)
        {
            Console.WriteLine(GameTitle + "\n");
            Console.WriteLine("Please use the menu below to Create a New Pet, Load an exisitng pet, or Exit the game.");
            Console.WriteLine("Enter the number of the option you want to select.");

            int optionNum = 1;
            foreach (var option in menuOptions)
            {
                Console.WriteLine($"{optionNum++}. {option}");
            }
        }

        public static bool MenuBuildAndSelection(List<string> MenuOptions)
        {
            do
            {
                DisplayOptions(MenuOptions);
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice)) {
                    if (numChoice == 3) {
                        Console.Clear();
                        Console.WriteLine("Thanks for playing! See you next time.");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                    }
                    else
                    {
                        switch (numChoice)
                        {
                            case 1:
                                Console.Clear();
                                // set up create menu
                                CreateMenu.BuildCreateMenu();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Loading your pet...");
                                // call load function
                                break;
                            default:
                                Console.WriteLine("Sorry, that was not valid. Please try again.");
                                Thread.Sleep(1500);
                                Console.Clear();
                                BuildMainMenu();
                                break;
                        }

                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Sorry, that is an invalid option. Please hit enter to try again.");
                    Console.ReadLine();
                }
            }
            while (true);
        }
    }
}
