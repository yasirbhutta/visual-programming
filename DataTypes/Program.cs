using System;

namespace DataTypes {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
           // FindRadius ();
           // Trigonometry ();
           UseDecimal();
        }

        static void FindRadius () {
            Double r;
            Double area;
            area = 10.0;
            r = Math.Sqrt (area / 3.1416);
            Console.WriteLine ("Radius is " + r);
        }

        //
        // Demonstrate Math.Sin(), Math.Cos(), and Math.Tan().
        static void Trigonometry () {
            Double theta; // angle in radians
            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1) {
                Console.WriteLine ("Sine of " + theta + " is " +
                    Math.Sin (theta));
                Console.WriteLine ("Cosine of " + theta + " is " +
                    Math.Cos (theta));
                Console.WriteLine ("Tangent of " + theta + " is " +
                    Math.Tan (theta));
                Console.WriteLine ();
            }
        }
        static void UseDecimal () {
            decimal price;
            decimal discount;
            decimal discounted_price;
            // Compute discounted price.
            price = 19.95m;
            discount = 0.15m; // discount rate is 15%
            discounted_price = price - (price * discount);
            Console.WriteLine ("Discounted price: $" + discounted_price);
        }

    }
}