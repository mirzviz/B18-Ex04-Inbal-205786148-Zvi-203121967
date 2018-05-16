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
            MenuItem timeDateShow = new MenuItem("Time/Date Show", 2);
            ActionMenu timeShow = new ActionMenu("Show Time", ShowTime);
            ActionMenu dateShow = new ActionMenu("Show Date", ShowDate);
            mainMenu.AddSubMenu(timeDateShow);
            timeDateShow.AddSubMenu(timeShow);
            timeDateShow.AddSubMenu(dateShow);
            mainMenu.RunMenu();
        }

        public static void CountChars()
        {
            string input;
            int charsCounter = 0;

            Console.WriteLine("Please enter a string:");
            input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLetter(input[i]))
                {
                    charsCounter++;
                }
            }

            Console.WriteLine("There are {0} Chars!", charsCounter);
        }

        public static void CountSpaces()
        {
            string input;
            int i;
            int spaceCounter = 0;

            Console.WriteLine("Please enter a string:");
            input = Console.ReadLine();
            i = 0;
            while (input[i] == ' ' && i < input.Length)
            {
                i++;
            }

            for (; i < input.Length - 1; i++)
            {
                if (input[i] == ' ' && input[i + 1] != ' ')
                {
                    spaceCounter++;
                }
            }

            Console.WriteLine("There are {0} spaces!", spaceCounter);
        }

        public static void DisplayVersion()
        {
            Console.WriteLine("App Version: 17.2.4.0");
        }

        public static void ShowDate()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
        }

        public static void ShowTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }
}
