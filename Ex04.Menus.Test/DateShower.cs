using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class DateShower : ActionInterface
    {
        public override void Action()
        {
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.ReadLine();
        }
    }
}
