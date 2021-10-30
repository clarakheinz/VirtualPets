﻿using System;
using System.Collections.Generic;

namespace VirtualPets
{
    class Program
    {
        static void Main(string[] args)
        {
            // look back at 10/20 class for app configuration to implement save and load methods for game

            //instantiate main menu
            MainMenu gameMenu = new MainMenu();

            //Set up options
            var mainOptions = gameMenu.MenuOptions();
            gameMenu.DisplayMenu(mainOptions);

        }
    }
}
