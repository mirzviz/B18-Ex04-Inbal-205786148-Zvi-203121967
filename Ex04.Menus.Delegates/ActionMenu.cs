using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void MethodHolder();

    public class ActionMenu : AbstractMenu
    {
        MethodHolder m_MethodHolderPtr;
        public ActionMenu(MethodHolder i_MethodHolderPtr)
        {
            m_MethodHolderPtr = i_MethodHolderPtr;
        }

        public override void RunMenu()
        {
            m_MethodHolderPtr.Invoke();
        }
    }
}
