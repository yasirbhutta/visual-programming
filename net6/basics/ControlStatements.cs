using System;
namespace CSharpBasics
{
    class ControlStatements
    {
        //listing 1
        // Determine if a value is positive or negative. 
        public static void PosNeg()
        {
            int i;

            for (i = -5; i <= 5; i++)
            {
                Console.Write("Testing " + i + ": ");

                if (i < 0) Console.WriteLine("negative");
                else Console.WriteLine("positive");
            }
        }
        //
        // listing 2
        // Determine if a value is positive, negative, or zero. 

        public static void PosNegZero()
        {
            int i;

            for (i = -5; i <= 5; i++)
            {

                Console.Write("Testing " + i + ": ");

                if (i < 0) Console.WriteLine("negative");
                else if (i == 0) Console.WriteLine("no sign");
                else Console.WriteLine("positive");
            }
        }

        //       
        //listing 4
        // Demonstrate the switch. 
        public static void SwitchDemo()
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
        //listing 5
        // Use a char to control the switch. 

        public static void SwitchDemo2()
        {

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
        public static void EmptyCasesCanFall()
        {
            int i;

            for (i = 1; i < 5; i++)
                switch (i)
                {
                    case 1:

                    case 2:

                    case 3:
                        Console.WriteLine("i is 1, 2 or 3");
                        break;
                    case 4:
                        Console.WriteLine("i is 4");
                        break;
                }
        }

        // listing 9
        // Use commas in a for statement. 
        public static void Comma()
        {
            int i, j;
            for (i = 0, j = 10; i < j; i++, j--)
                Console.WriteLine("i and j: " + i + " " + j);

        }
        public static void InfFor()
        {
            int i = 0;
            for (; ; ) // intentionally infinite loop
            {
                //...
                Console.WriteLine("i = " + i);

                if (i >= 5) break;
                i++;
            }
        }

        //listing 16
        // Compute the order of magnitude of an integer 


        public static void WhileDemo()
        {
            int num;
            int mag;

            num = 435679;
            mag = 0;

            Console.WriteLine("Number: " + num);

            while (num > 0)
            {
                mag++;
                num = num / 10;
                Console.WriteLine("num = {0}", num);
            };

            Console.WriteLine("Magnitude: " + mag);
        }
        public static void GotoDemo()
        {
            int x;
            x = 1;
        // label for goto
        loop1:
            x++;
            if (x < 100) goto loop1;
            Console.WriteLine("x = {0}", x);
        }

    }
}
