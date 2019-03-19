using System;

namespace DataTypes {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
            FindRadius();
        }

        static void FindRadius() {
            Double r;
            Double area;
            area = 10.0;
            r = Math.Sqrt (area / 3.1416);
            Console.WriteLine ("Radius is " + r);
        }
    }
}