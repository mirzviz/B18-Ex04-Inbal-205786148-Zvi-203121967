using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public delegate void MethodHolder();

    public class ActionMenu : AbstractMenu
    {
        private ActionInterface m_Action;

        public ActionMenu(string i_Name, ActionInterface i_Action)
        {
            MenuName = i_Name;
            m_Action = i_Action;
        }

        public override void RunMenu()
        {
            Console.Clear();
            m_Action.Action();
        }
    }
}
