using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public delegate void MyDel();
        public static void Main()
        {
            MyDel del = new MyDel(func1);
            del += func2;
            del.Invoke();
        }

        public static void func1()
        {
            Console.WriteLine("func1");
        }

        public static void func2()
        {
            Console.WriteLine("func2");
        }
    }
}
