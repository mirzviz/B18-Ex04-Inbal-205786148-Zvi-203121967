using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    class MenuItem : AbstractMenu
    {
        private List<AbstractMenu> m_SubMenusList;

        private int m_Level;

        public MenuItem(string i_Name, int i_Level)
        {
            MenuName = i_Name;
            m_Level = i_Level;
        }

        public void AddSubMenu(AbstractMenu i_SubMenuToAdd)
        {
            m_SubMenusList[m_SubMenusList.Count] = i_SubMenuToAdd;
        }

        public override void RunMenu()
        {
            showMenu();
            int UsersChoice = getUsersChoice();
            while(UsersChoice != 0 || m_Level != 1) 
            {
                m_SubMenusList[UsersChoice - 1].RunMenu();
            }
        }

        private void showMenu()
        {
            Console.WriteLine("Level: {0}", m_Level);

        }
    }
}
