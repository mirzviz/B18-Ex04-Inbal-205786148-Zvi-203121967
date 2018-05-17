using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main()
        {
            DelegateWay();
            InterfaceWay();
        }

        public static void DelegateWay()
        {
            Ex04.Menus.Delegates.MenuItem mainMenu = new Ex04.Menus.Delegates.MenuItem("Main Menu", 1);
            Ex04.Menus.Delegates.MenuItem timeDateShow = new Ex04.Menus.Delegates.MenuItem("Time/Date Show", 2);
            Ex04.Menus.Delegates.MenuItem capitalsAndVersion = new Ex04.Menus.Delegates.MenuItem("Capitals and Version", 2);
            Ex04.Menus.Delegates.ActionMenu timeShow = new Ex04.Menus.Delegates.ActionMenu("Show Time", ShowTime);
            Ex04.Menus.Delegates.ActionMenu dateShow = new Ex04.Menus.Delegates.ActionMenu("Show Date", ShowDate);
            Ex04.Menus.Delegates.ActionMenu countCapitals = new Ex04.Menus.Delegates.ActionMenu("Count Capitals", CountCapitals);
            Ex04.Menus.Delegates.ActionMenu showVersion = new Ex04.Menus.Delegates.ActionMenu("Show Version", ShowVersion);
            mainMenu.AddSubMenu(timeDateShow);
            mainMenu.AddSubMenu(capitalsAndVersion);
            timeDateShow.AddSubMenu(timeShow);
            timeDateShow.AddSubMenu(dateShow);
            capitalsAndVersion.AddSubMenu(countCapitals);
            capitalsAndVersion.AddSubMenu(showVersion);
            mainMenu.RunMenu();
        }

        public static void InterfaceWay()
        {
            Ex04.Menus.Interfaces.MenuItem mainMenu = new Ex04.Menus.Interfaces.MenuItem("Main Menu", 1);
            Ex04.Menus.Interfaces.MenuItem timeDateShow = new Ex04.Menus.Interfaces.MenuItem("Time/Date Show", 2);
            Ex04.Menus.Interfaces.MenuItem capitalsAndVersion = new Ex04.Menus.Interfaces.MenuItem("Capitals and Version", 2);
            Ex04.Menus.Interfaces.ActionMenu timeShow = new Ex04.Menus.Interfaces.ActionMenu("Show Time", new TimeShower());
            Ex04.Menus.Interfaces.ActionMenu dateShow = new Ex04.Menus.Interfaces.ActionMenu("Show Date", new DateShower());
            Ex04.Menus.Interfaces.ActionMenu countCapitals = new Ex04.Menus.Interfaces.ActionMenu("Count Capitals", new CapitalsCounter());
            Ex04.Menus.Interfaces.ActionMenu showVersion = new Ex04.Menus.Interfaces.ActionMenu("Show Version", new VersionShower());
            mainMenu.AddSubMenu(timeDateShow);
            mainMenu.AddSubMenu(capitalsAndVersion);
            timeDateShow.AddSubMenu(timeShow);
            timeDateShow.AddSubMenu(dateShow);
            capitalsAndVersion.AddSubMenu(countCapitals);
            capitalsAndVersion.AddSubMenu(showVersion);
            mainMenu.RunMenu();
        }
        
        public static void CountCapitals()
        {
            string input;
            int capitalCounter = 0;

            Console.WriteLine("Please enter a string:");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    capitalCounter++;
                }
            }

            Console.WriteLine("There are {0} capital letters!", capitalCounter);
            Console.ReadLine();
        }

        public static void ShowVersion()
        {
            Console.WriteLine("App Version: 18.2.4.0");
            Console.ReadLine();
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.ReadLine();
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.ReadLine();
        }
    }
}
