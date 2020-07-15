using System;

namespace ScopeCasting {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Hello World!");
        }
        static void ScopeDemo () {

            int x; // known to all code within Main() 

            x = 10;
            if (x == 10) { // start new scope
                int y = 20; // known only to this block 

                // x and y both known here. 
                Console.WriteLine ("x and y: " + x + " " + y);
                x = y * 2;
            }
        // y = 100; // Error! y not known here  

            // x is still known here. 
            Console.WriteLine ("x is " + x);
        }

        static void VarInitDemo () {
            int x;

            for (x = 0; x < 3; x++) {
                int y = -1; // y is initialized each time block is entered 
                Console.WriteLine ("y is: " + y); // this always prints -1 
                y = 100;
                Console.WriteLine ("y is now: " + y);
            }
        
        }

        /*  
   This program attempts to declare a variable 
   in an inner scope with the same name as one 
   defined in an outer scope. 
 
   *** This program will not compile. *** 
*/
       static void NestVar () { 
              int count;

              for (count = 0; count < 10; count = count + 1) {
                  Console.WriteLine ("This is count: " + count);

                  int count; // illegal!!! 
                  for (count = 0; count < 2; count++)
                      Console.WriteLine ("This program is in error!");
              } 
              
        // Demonstrate implicit conversion from long to double.
        static void LtoD () {
            long L;
            double D;
            L = 100123285L;
            D = L;
            Console.WriteLine ("L and D: " + L + " " + D);
        }
    }
}