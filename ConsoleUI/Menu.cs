using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Menu
    {
        private List<UserOption> menuOptions = new List<UserOption>(0);

        public void Add(UserOption option)
        {
            menuOptions.Add(option);
        }

        public void Add(params UserOption[] options)
        {

        }

        public Menu()
        {
            menuOptions.Add(exit);
        }
    }
}
