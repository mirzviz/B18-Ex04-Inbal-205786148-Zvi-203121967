using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public abstract class AbstractMenu
    {
        private string m_MenuName;

        public string MenuName
        {
            get
            {
                return m_MenuName;
            }

            set
            {
                m_MenuName = value;
            }
        }

        public abstract void RunMenu();
    }
}
