using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton__одиночка_
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSingleton.getInstance().print();//пример вызова функций из нашего класса
        }
    }
}
