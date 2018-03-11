using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World! ");
             Console.Write("Press any key to continue...");
             Console.ReadKey(true); */
            NameDemo();
            

        }
        static void NameDemo()
        {
            //
            // Enhancing the Hello World application
            //
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);

        }
    }
}
