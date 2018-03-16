using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            StructDemo();
            //
            Console.ReadKey();
        }
        //
        // struct
        //
        struct Books {
            public string title;
            public string author;
        };
        static void StructDemo () {
            Books book1, book2;
            book1.title = "C# 5.0";
            book1.author = "Herbert Schildt";
            book2.title = "Network basics";
            book2.author = "Muhammad Umer";
            // print book1 info
            Console.WriteLine ("***** " + book1.title + " *****");
            Console.WriteLine (book1.author);
            // print book2 info

            Console.WriteLine ("***** " + book2.title + " *****");
            Console.WriteLine (book2.author);

        }
    }
}
