﻿using System;
//
// for collections
//
using System.Collections.Generic;
namespace collections
{
    class Program
    {
        //
        // enum
        //
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        static void Main(string[] args)
        {
            EnumDemo();
            //ArrayDemo();
            //ListDemo1 ();
            //ListDemo2();
            //ListDemo3();
           //ListDemo4();
            Console.ReadKey(true);
        }

        //
        // Arrays
        //
        static void ArrayDemo()
        {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = i * i;
            }
            Console.WriteLine($"Length of Array {a.Length}");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"a[{i}] = {a[i]}");
            }
        }

        static void ListDemo1()
        {

            List<int> iList = new List<int>();
            iList.Add(2);
            iList.Add(4);
            iList.Add(5);
            iList.Add(10);
            iList.Add(12);
            foreach (int a in iList)

                Console.WriteLine(a);


        }
        static void ListDemo2()
        {
            List<string> sList = new List<string>();
            sList.Add("red");
            sList.Add("green");
            sList.Add("blue");
            foreach (string str in sList)
                Console.WriteLine(str);
        }
        static void ListDemo3()
        {
            var names = new List<string> { "hamza", "ali", "ahmed" };

            foreach (var name in names)
            {

                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        //
        // Modify list contents
        //
        static void ListDemo4()
        {
            var names = new List<string>();

            //
            Console.WriteLine("***** New List ******");
            names.Add("zeshan");
            names.Add("Muhammad Umer");
            names.Add("nasir");

            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine("***** New list after removing item ******");
            names.Remove("zeshan");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }

        static void EnumDemo()
        {
            
            int x = (int)Day.Sun;
            int y = (int)Day.Fri;
            Console.WriteLine("Sun = {0}", x);
            Console.WriteLine("Fri = {0}", y);
            //
            //
            Day d;
            
            d = Day.Sun;
            switch (d)
            {
                case Day.Sun:
                    Console.WriteLine("Holiday ....");
                    break;
                default:
                    Console.WriteLine("Weekday ....");
                    break;
            }
        }
    }
}