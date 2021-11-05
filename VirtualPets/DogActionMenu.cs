using System;
using System.Collections.Generic;
using System.Threading;
using VirtualPets.Utilities;

namespace VirtualPets
{
    public class DogActionMenu
    {
        public static void BuildDogActionMenu(Dog dog)
        {
            var options = DogActionMenu.MenuOptions();
            DogActionMenu.MenuBuildAndSelection(options, dog);

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
                "Do nothing",
                "Save",
                "Exit"
            };
        }

        public static void DisplayOptions(List<string> MenuOptions, Dog dog)
        {
            Console.Clear();
            Console.WriteLine(menuTitle);
            Console.WriteLine("Now you can interact with your dog. Enter the number of the option you want to select.");
            Console.WriteLine($"What do you want to do with {dog.Name}?");

            int optionNum = 1;
            foreach (var option in MenuOptions)
            {
                Console.WriteLine($"{optionNum++}. {option}");
            }
            Console.WriteLine();
        }



        public static void MenuBuildAndSelection(List<String> MenuOptions, Dog dog)
        {
            var continueGame = true;
            do
            {
                DisplayOptions(MenuOptions, dog);
                string choice = Console.ReadLine();
                if (Int32.TryParse(choice, out int numChoice))
                {

                    switch (numChoice)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Pet();
                            dog.Pet();
                            dog.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Play
                            dog.Play();
                            dog.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Feed()
                            dog.Feed();
                            dog.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            // call petObject.Walk()
                            dog.Walk();
                            dog.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 5:
                            Console.Clear();
                            Console.WriteLine(menuTitle);
                            dog.DoNothing();
                            dog.PrintStats();
                            Console.WriteLine("Press enter to continue.");
                            Console.ReadLine();
                            break;
                        case 6:
                            SaveUtil.SaveGame(dog);
                            Console.WriteLine("Your game has saved! Hit enter to continue.");
                            Console.ReadLine();
                            break;
                        case 7:
                            // exit to main menu
                            Console.Clear();
                            Console.WriteLine("You're exiting to the main menu. I hope you saved!");
                            Thread.Sleep(1500);
                            continueGame = false;
                            return;
                        default:
                            // not sure what to do here
                            Console.WriteLine("Sorry, that was not valid. Hit enter to try again.");
                            Console.ReadLine();
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Sorry, that is an invalid option.");
                    Console.WriteLine("Press enter to continue.");
                    Console.ReadLine();
                }
            }
            while (continueGame);
        }
    }
}
