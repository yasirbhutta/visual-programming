using System;
//
// for collections
//
using System.Collections.Generic;
namespace collections {
    class Program {
        static void Main (string[] args) {
            EnumDemo ();
            Console.ReadKey (true);
        }
        //
        // Arrays
        //
        static void ArrayDemo () {
            int[] a = new int[10];
            for (int i = 0; i < a.Length; i++) {
                a[i] = i * i;
            }
            for (int i = 0; i < a.Length; i++) {
                Console.WriteLine ($"a[{i}] = {a[i]}");
            }
        }
        static void ListDemo1 () {
            var names = new List<string> { "hamza", "ali", "ahmed" };
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }
        }
        //
        // Modify list contents
        //
        static void ListDemo2 () {
            var names = new List<string> { "zeshan", "ali", "ahmed" };
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }
            //
            //
            //
            Console.WriteLine ("***** New List ******");
            names.Add ("Muhammad Umer");
            names.Add ("nasir");
            names.Remove ("zeshan");
            foreach (var name in names) {
                Console.WriteLine ($"Hello {name.ToUpper()}!");
            }
        }
        
        //
        // enum
        //
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        static void EnumDemo () {
 int x = (int) Day.Sun;
 int y = (int) Day.Fri;
 Console.WriteLine ("Sun = {0}", x);
 Console.WriteLine ("Fri = {0}", y);
 //
 //
 Day d;
 d = Day.Sun;
 switch (d) {
 case Day.Sun:
 Console.WriteLine ("Holiday ....");
 break;
 default:
 Console.WriteLine ("Weekday ....");
 break;
            }
        }
    }
}