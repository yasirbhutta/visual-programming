using System;

namespace myApp {
    public class chap02 {
        public chap02 () { }
        public void example1 () {
            Console.WriteLine ("A simple C# program.");

        }
        public void example2 () {
            // System.Console.WriteLine("A simple C# program."); 

        }
        //
        // This program demonstrates variables.  
        //
        public void example3 () {
            int x; // this declares a variable  
            int y; // this declares another variable  

            x = 100; // this assigns 100 to x 

            Console.WriteLine ("x contains " + x);

            y = x / 2;

            Console.Write ("y contains x / 2: ");
            Console.WriteLine (y);

        }

    }
}