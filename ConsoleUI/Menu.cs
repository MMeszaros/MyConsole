using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Menu
    {
        private List<MenuOption> options;

        private Menu baseMenu;

        public List<MenuOption> Options { get; }

        public void AddOption()
        {
            options.Add(new MenuOption());
        }

        public Menu()
        {
            options = new List<MenuOption>();

            this.baseMenu = this;
        }

        public Menu(Menu baseMenu)
        {
            options = new List<MenuOption>();

            this.baseMenu = baseMenu;
        }
    }
}
