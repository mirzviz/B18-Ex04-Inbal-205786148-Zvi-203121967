using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class AbstractMenu
    {
        private String m_MenuName;

        public String MenuName
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
