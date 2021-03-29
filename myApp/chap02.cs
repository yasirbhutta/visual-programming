using System;

namespace myApp {
    public class chap02 {
        public chap02 () { }
        public void example1 () {
            //Console.WriteLine ("A simple C# program.");
            example2();
        }
        public void example2 () {

 
             System.Console.WriteLine("A simple C# program."); 

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
        //
        //  Compute the area of a circle. 
        //
        public void example4 () {

            double radius;
            double area;

            radius = 10.0;
            area = radius * radius * 3.1416;

            Console.WriteLine ("Area is " + area);

        }
        //
        // Demonstrate the if.
        //
        public void example5 () {
            int a, b, c;

            a = 2;
            b = 3;

            if (a < b) Console.WriteLine ("a is less than b");

            // This won't display anything. 
            if (a == b) Console.WriteLine ("you won't see this");

            Console.WriteLine ();

            c = a - b; // c contains -1 

            Console.WriteLine ("c contains -1");
            if (c >= 0) Console.WriteLine ("c is non-negative");
            if (c < 0) Console.WriteLine ("c is negative");

            Console.WriteLine ();

            c = b - a; // c now contains 1 
            Console.WriteLine ("c contains 1");
            if (c >= 0) Console.WriteLine ("c is non-negative");
            if (c < 0) Console.WriteLine ("c is negative");
        }

        public void example6()
        {
            var str = "1"; 
            var num = 0;

            Console.WriteLine(str);
            Console.WriteLine(num);

        }
        //
        //  Demonstrate the for loop.
        //
        public void ForDemo () {
            int count;

            for (count = 0; count < 5; count = count + 1)
                Console.WriteLine ("This is count: " + count);

            Console.WriteLine ("Done!");

        }
        //
        // Demonstrate a block of code. 
        //
        public void BlockDemo () {

            int i, j, d;
            i = 5;
            j = 10;
            

            // The target of this if is a block. 
            if (i != 0) {
                //int k = 5;
                Console.WriteLine ("i does not equal zero");
                d = j / i;
                Console.WriteLine ("j / i is " + d);
                //Console.WriteLine("K = " + k);
            }
            // error 'k' does not exist in current  
            // Console.WriteLine("k =" + k); 
        }
        //
        // Compute the sum and product of the numbers from 1 to 10. 
        //
        public void ProdSum () {
            int prod;
            int sum;
            int i;

            sum = 0;
            prod = 1;

            for (i = 1; i <= 10; i++) {
                sum = sum + i;
                prod = prod * i;
            }
            Console.WriteLine ("Sum is " + sum);
            Console.WriteLine ("Product is " + prod);

        }
        //
        // Demonstrate ReadLine()
        //
        public void ReadDemo () {
            
            int a;
            string name;
            Console.Write("Enter your name = ");
            name = Console.ReadLine();
            Console.WriteLine("name = " + name);
            //
            Console.Write ("Please enter numeric value = ");
           
            a = Convert.ToInt32 (Console.ReadLine ());

            Console.WriteLine ("a = " + a );

        }
        //
        // Demonstrate an @ identifier. 
        //
        public void IdTest () {
                int @if,@for; // use if as an identifier 
                @for = 50;
                for (@if = 0; @if < 10; @if++) 
                Console.WriteLine (" @if is " + @if); 
                Console.WriteLine(@for);
            }
        }   // end class block
   
   
    }   // end namespace block