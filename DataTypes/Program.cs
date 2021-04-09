using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine ("Hello World!");
            //FindRadius ();
            //Trigonometry ();
            //UseDecimal ();
            //BoolDemo();
            //DisplayOptions();
            //StrDemo ();
            // verbatim();
            StrIntp();
        }

        static void FindRadius()
        {
            double r;
            Double area;
            area = 10.0;
            r = Math.Sqrt(area / 3.1416);
            Console.WriteLine("Radius is " + r);
        }

        //
        // Demonstrate Math.Sin(), Math.Cos(), and Math.Tan().
        static void Trigonometry()
        {
            Double theta; // angle in radians

            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
            {

                Console.WriteLine("Sine of " + theta + " is " +
                    Math.Sin(theta));

                Console.WriteLine("Cosine of " + theta + " is " +
                    Math.Cos(theta));

                Console.WriteLine("Tangent of " + theta + " is " +
                    Math.Tan(theta));

                Console.WriteLine();
            }
        }
        static void UseDecimal()
        {
            decimal price;
            decimal discount;
            decimal discounted_price;

            // Compute discounted price.
            price = 19.95m;
            discount = 0.15m; // discount rate is 15%
            discounted_price = price - (price * discount);
            Console.WriteLine("Discounted price: $" + discounted_price);
        }
        static void BoolDemo()
        {
            bool b;
            b = false;
            Console.WriteLine("b is " + b);
            b = true;
            Console.WriteLine("b is " + b);
            // A bool value can control the if statement.
            if (b) Console.WriteLine("This is executed.");
            b = false;
            if (b) Console.WriteLine("This is not executed.");
            // Outcome of a relational operator is a bool value.
            Console.WriteLine("10 > 9 is " + (10 > 9));
        }

        static void DisplayOptions()
        {
            int i;
            int d1, d2;
            d1 = 28; d2 = 29;
            //long l;
            //l=333344899999999;
            //
            Console.WriteLine("10.0/3.0 is" + 10.0 / 3.0);
            //
            Console.WriteLine("{1}/3.0 is {0}", (10.0 / 3.0), 10);

            Console.WriteLine("Here is 10/3: {0:#.##}", 10.0 / 3.0);
            //   
            Console.WriteLine("February has {0,10} or {1,5}", d1, d2);
            //
            //
            Console.WriteLine("Here is 10/3: {0:#.##}", 10.0 / 3.0);
            Console.WriteLine("{0:###,###.##}", 123456.56);
            //
            decimal balance = 12323.09m;
            Console.WriteLine("Current balance is {0:C}", balance);

            //

            Console.WriteLine("Value\tSquared\tCubed");
            for (i = 1; i < 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);

            Console.WriteLine("Here is 10/3: {0:#.##}", 10.0 / 3.0);
        }
        //
        // Demonstrate escape sequences in strings.
        //
        static void StrDemo()
        {

            //  \n escape sequence is used to generate a new line.
            Console.WriteLine("Line One\nLine Two\nLine Three");
            Console.WriteLine("One\tTwo\tThree");
            Console.WriteLine("Four\tFive\tSix");
            // Embed quotes.
            Console.WriteLine("\"Why?\", he asked.");
        }

        static void verbatim()
        {
            Console.WriteLine(@"This is a verbatim
                                string literal
                                that spans several lines.
                                ");
            Console.WriteLine(@"Here is some tabbed output:
                        1   2   3   4
                        5   6   7   8
                        ");
            Console.WriteLine(@"Programmers say, ""I like C#.""");
        }
        static void StrIntp()
        {
            string name = "Mark";
            var date = DateTime.Now;

            // Composite formatting:

            Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);

            // String interpolation:

            Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");

        }
    }
}
