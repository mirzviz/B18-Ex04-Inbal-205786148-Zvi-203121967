using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        { 
            MenuItem mainMenu = new MenuItem("Main Menu", 1);
            MenuItem subMenu = new MenuItem("a sub menu", 2);
            mainMenu.AddSubMenu(subMenu);
            mainMenu.RunMenu();
        }
        
    }
}
