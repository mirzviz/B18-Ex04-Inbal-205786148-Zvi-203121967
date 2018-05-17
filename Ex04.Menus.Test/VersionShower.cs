using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;


namespace Ex04.Menus.Test
{
    public class VersionShower : ActionInterface
    {
        public override void Action()
        {
            Console.WriteLine("App Version: 18.2.4.0");
            Console.ReadLine();
        }
    }
}
