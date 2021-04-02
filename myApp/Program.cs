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
        //ch.example6();
        //print();
        //ShowSum();  
            Console.ReadLine();
        }
        static void print()
        {

            Console.WriteLine("Ghazi University");
        
        }
        static void ShowSum()
        {
            int x;
            x=10;
            Console.WriteLine($"x = {x}");
            //
            //
            int a, b,sum;
            a=5; b=10;
            sum = a+b;
            Console.WriteLine ("sum = " + sum);
        }        
    }  
}
