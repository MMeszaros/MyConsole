using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class MenuOption
    {
        private Menu subMenu;

        internal Menu BaseMenu { get; }

        public MenuOption()
        {
            subMenu = null;
        }
    }
}
