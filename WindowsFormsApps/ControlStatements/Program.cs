using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            SwitchDemo1();
        }
        static void SwitchDemo1()
        {
            int i;
            for (i = 0; i < 10; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine("i is zero");
                        break;
                    case 1:
                        Console.WriteLine("i is one");
                        break;
                    case 2:
                        Console.WriteLine("i is two");
                        break;
                    case 3:
                        Console.WriteLine("i is three");
                        break;
                    case 4:
                        Console.WriteLine("i is four");
                        break;
                    default:
                        Console.WriteLine("i is five or more");
                        break;
                }
        }
    }
}

    }
}
