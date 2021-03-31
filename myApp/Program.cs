using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
         // Console.WriteLine("Hello world");
            
        chap02 ch = new chap02();
        ch.IdTest();
        //print();
        //  ShowSum();  
            
        }

        static void print()
        {
            Console.WriteLine("Ghazi University");
        }
        static void ShowSum()
        {
            int a, b,sum;
            a=5; b=10;
            sum = a+b;
            Console.WriteLine ("sum = " + sum);
        }
        
    }  
}
