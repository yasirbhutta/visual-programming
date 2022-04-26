using System;

namespace classes {
    class css {
        static void call () {
            
            // Call the constructor that has no parameters.
        Person person1 = new Person();
        Console.WriteLine(person1.name);

        person1.SetName("Muhammad Ahmad");
        Console.WriteLine(person1.name);

        // Call the constructor that has one parameter.
        Person person2 = new Person("Muhammad Hamza");
        Console.WriteLine(person2.name);

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
            //
        
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