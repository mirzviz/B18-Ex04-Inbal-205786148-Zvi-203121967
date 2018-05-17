using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CapitalsCounter : ActionInterface
    {
        public override void Action()
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
    }
}
