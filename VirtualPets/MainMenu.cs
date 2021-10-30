using System;
using System.Collections.Generic;

namespace VirtualPets
{
    public class MainMenu : IMenu
    {

        public string GameTitle = @"
#     #                                       ######                      
#     # # #####  ##### #    #   ##   #        #     # ###### #####  ####  
#     # # #    #   #   #    #  #  #  #        #     # #        #   #      
#     # # #    #   #   #    # #    # #        ######  #####    #    ####  
 #   #  # #####    #   #    # ###### #        #       #        #        # 
  # #   # #   #    #   #    # #    # #        #       #        #   #    # 
   #    # #    #   #    ####  #    # ######   #       ######   #    #### 
";


        public List<string> MenuOptions()
        {
            return new List<string>
            {
                "Create New Pet",
                "Load Pet",
                "Exit"
            };
        }

        public void DisplayMenu(List<string> menuOptions)
        {
            Console.Clear();
            Console.WriteLine(GameTitle + "\n");
            Console.WriteLine("Please use the menu below to Create a New Pet, Load an exisitng pet, or Exit the game.");
            Console.WriteLine("Enter the number of the option you want to select.");

            int optionNum = 1;
            foreach (var option in menuOptions)
            {
                Console.WriteLine($"{optionNum++}. {option}");
            }
        }

        public int MenuSelection(List<string> menuOptions)
        {
            do
            {
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice)) {
                    if (numChoice == 3) {
                        Console.Clear();
                        Console.WriteLine("Thanks for playing! See you next time.");
                        Environment.Exit(0);
                    }
                    else
                    {
                        return numChoice; // need to call sub menues from this
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
