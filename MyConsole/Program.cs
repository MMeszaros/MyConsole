using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int foo = 10;
            object obj = foo;

            Console.WriteLine(obj.GetType());
            Console.ReadLine();
        }
    }
}
