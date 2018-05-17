using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void MethodHolder();

    public class ActionMenu : AbstractMenu
    {
        private MethodHolder m_MethodHolderPtr;

        public ActionMenu(string i_Name, MethodHolder i_MethodHolderPtr)
        {
            MenuName = i_Name;
            m_MethodHolderPtr = i_MethodHolderPtr;
        }

        public override void RunMenu()
        {
            Console.Clear();
            m_MethodHolderPtr();
        }
    }
}
