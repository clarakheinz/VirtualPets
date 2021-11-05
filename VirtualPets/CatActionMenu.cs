using System;
using System.Collections.Generic;
using System.Threading;
using VirtualPets.Utilities;

namespace VirtualPets
{
    public class CatActionMenu 
    {
        public static void BuildCatActionMenu(Cat cat)
        {
            var options = CatActionMenu.MenuOptions();
            CatActionMenu.MenuBuildAndSelection(options, cat);
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
                "Do nothing",
                "Save",
                "Exit"
            };
        }

        public static void DisplayOptions(List<string> MenuOptions, Cat cat)
        {
            Console.Clear();
            Console.WriteLine(menuTitle);
            Console.WriteLine($"Now you can interact with your cat. Enter the number of the option you want to select.");
            Console.WriteLine($"What do you want to do with {cat.Name}?");

            int optionNum = 1;
            foreach (var option in MenuOptions)
            {
                Console.WriteLine($"{optionNum++}. {option}");
            }
            Console.WriteLine();
        }

        public static void MenuBuildAndSelection(List<string> MenuOptions, Cat cat)
        {
            var continueGame = true;
            do
            {
                
                DisplayOptions(MenuOptions, cat);
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice))
                {

                    switch (numChoice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Pet();
                            cat.Pet();
                            cat.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Play
                            cat.Play();
                            cat.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Feed()
                            cat.Feed();
                            cat.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            cat.DoNothing();
                            cat.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 5:
                            SaveUtil.SaveGame(cat);
                            Console.WriteLine("Your game has saved! Hit enter to continue.");
                            Console.ReadLine();
                            break;
                        case 6:
                            //mainmenu
                            Console.Clear();
                            Console.WriteLine("You're exiting to the main menu. I hope you saved!");
                            Thread.Sleep(1000);
                            continueGame = false;
                            return;
                        default:
                            // not sure what to do here
                            Console.WriteLine("Sorry, that was not valid. Please hit enter to try again.");
                            Console.ReadLine();
                            break;
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
