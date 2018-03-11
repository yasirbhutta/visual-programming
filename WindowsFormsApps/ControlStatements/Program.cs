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
            ifDemo();
            //
            // 
            //
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
        static void ifDemo()
        {
            int a = 5;
            int b = 6;  // Modify the declaration of b so that the sum is less than 10: int b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10.");

        }
        static void ifelseDemo1()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
                Console.WriteLine("The answer is greater than 10");
            else
                Console.WriteLine("The answer is not greater than 10");
        }
        static void ifelseDemo2()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }
        }
        static void ifelseDemo3()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            /* The && represents "and". 
            It means both conditions must be true 
                to execute the statement in the true branch. */
            if ((a + b + c > 10) && (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not greater than the second");
            }
        }
        static void ifelseDemo4()
        {
            int a = 5;
            int b = 3;
            int c = 4;
            if ((a + b + c > 10) || (a > b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is greater than the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not greater than the second");
            }
        }
        static void switchDemo1()
        {
            // Demonstrate the switch.
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
        static void switchDemo2()
        {
            // Use a char to control the switch.
            char ch;
            for (ch = 'A'; ch <= 'E'; ch++)
                switch (ch)
                {
                    case 'A':
                        Console.WriteLine("ch is A");
                        break;
                    case 'B':
                        Console.WriteLine("ch is B");
                        break;
                    case 'C':
                        Console.WriteLine("ch is C");
                        break;
                    case 'D':
                        Console.WriteLine("ch is D");
                        break;
                    case 'E':
                        Console.WriteLine("ch is E");
                        break;
                }
        }
    }
}



