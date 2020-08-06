using System;

namespace ScopeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CastDemo();
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

                 // int count; // illegal!!! 
                  for (count = 0; count < 2; count++)
                      Console.WriteLine ("This program is in error!");
              } 
       }
        // Demonstrate implicit conversion from long to double.
        static void LtoD () {
            long L;
            double D;
            L = 100123285L;
            D = L;
            Console.WriteLine ("L and D: " + L + " " + D);
        }
        static void BytetoInt()
        {
            byte b=20;
            int i,j;
            long l;
            j=100;
            i=100;
            i=b;
            l=j;
            Console.WriteLine(i);

        }
         
  static void CastDemo() {    
    double x, y; 
    byte b; 
    int i; 
    char ch; 
    uint u; 
    short s; 
    long l; 
 
    x = 10.0; 
    y = 3.0; 
 
    // Cast double to int, fractional component lost. 
    i = (int) (x / y);  
    Console.WriteLine("Integer outcome of x / y: " + i); 
    Console.WriteLine(); 
     
    // Cast an int into a byte, no data lost. 
    i = 255; 
    b = (byte) i;  
    Console.WriteLine("b after assigning 255: " + b + 
                      " -- no data lost."); 
 
    // Cast an int into a byte, data lost. 
    i = 257; 
    b = (byte) i;  
    Console.WriteLine("b after assigning 257: " + b + 
                      " -- data lost."); 
    Console.WriteLine(); 
 
    // Cast a uint into a short, no data lost. 
    u = 32000; 
    s = (short) u; 
    Console.WriteLine("s after assigning 32000: " + s + 
                      " -- no data lost.");  
 
    // Cast a uint into a short, data lost. 
    u = 64000; 
    s = (short) u; 
    Console.WriteLine("s after assigning 64000: " + s + 
                      " -- data lost.");  
    Console.WriteLine(); 
 
    // Cast a long into a uint, no data lost. 
    l = 64000; 
    u = (uint) l; 
    Console.WriteLine("u after assigning 64000: " + u + 
                      " -- no data lost.");  
 
    // Cast a long into a uint, data lost. 
    l = -12; 
    u = (uint) l; 
    Console.WriteLine("u after assigning -12: " + u + 
                      " -- data lost.");  
    Console.WriteLine(); 
 
    // Cast an int into a char. 
    b = 120; // ASCII code for X 
    ch = (char) b; 
    Console.WriteLine("ch after assigning 88: " + ch);  
      
}


    }
}
