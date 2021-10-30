using System;
using System.Collections.Generic;

namespace VirtualPets
{
    public interface IMenu
    {
        public List<string> MenuOptions();
        public void DisplayMenu(List<string> MenuOptions);
        public int MenuSelection(List<string> menuOptions);
    }
}
