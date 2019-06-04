using System;
using System.Collections;
using System.Collections.Generic;

namespace Class25
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Why ArrayList's suck
            var myArrayList = new ArrayList();
            myArrayList.Add(56);
            myArrayList.Add("Jason");
            // Exception thrown here!!!!
            // var value = (int)myArrayList[1];

            // Array
            var myArray = new int[5];
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i;
            }

            // How do I resize an array?  You don't
            var myArray2 = new int[10];
            Array.Copy(myArray, myArray2, myArray.Length);
            // myArray.CopyTo(myArray2, myArray.Length);

            // List
            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Capacity - {list.Capacity}, Count - {list.Count}");
                list.Add($"{i}");
            }

            // Remove by value
            list.Remove("2");

            // Remove by index
            list.RemoveAt(2);

            list.Contains("2"); // will be false

            var test = new string[2];
            list.AddRange(test);

            var test2 = new List<string>();
            test2.Add("Hello");
            test2.Add("World");
            list.AddRange(test2);

            // Dictionaries
            var books = new List<Book>
            {
                new Book { Author = "Me", Title = "My Life" },
                new Book { Author = "Adam", Title = "His Life" },
                new Book { Author = "Our Class", Title = "Our Life" }
            };
            // Collection Initialization, short hand for 
            //books.Add(new Book { Author = "Me", Title = "My Life" });
            //books.Add(new Book { Author = "Adam", Title = "His Life" });
            //books.Add(new Book { Author = "Our Class", Title = "Our Life" });

            // Finding a book - O(n)
            Book myBook = null;
            foreach (var book in books)
            {
                if (book.Title.Equals("My Life"))
                {
                    myBook = book;
                    break;
                }
            }

            var betterBooks = new Dictionary<string, Book>
            {
                { "My Life", new Book { Author = "Me", Title = "My Life" } },
                { "His Life", new Book { Author = "Adam", Title = "His Life" } },
                { "Our Life", new Book { Author = "Our Class", Title = "Our Life" } }
            };
            // Shorthand for...
            //betterBooks.Add("My Life", new Book { Author = "Me", Title = "My Life" });
            //betterBooks.Add("His Life", new Book { Author = "Adam", Title = "His Life" });
            //betterBooks.Add("Our Life", new Book { Author = "Our Class", Title = "Our Life" });

            // Dictionaries are more effecient for searching because the key is computed
            // as a hash and retrieved from the ordered hashtable

            // Throws an exception for duplicate keys
            // betterBooks.Add("My Life", new Book());
            myBook = betterBooks["My Life"];

            // Looping through dictionaries
            foreach (var kvp in betterBooks)
            {
                Console.WriteLine($"Key - {kvp.Key}, Value - {kvp.Value.Author}");
            }

            // Queue (FIFO) First-In First-Out
            var myQueue = new Queue<Book>();
            myQueue.Enqueue(new Book { Author = "Me", Title = "My Life" });
            myQueue.Enqueue(new Book { Author = "Adam", Title = "His Life" });
            myQueue.Enqueue(new Book { Author = "Our Class", Title = "Our Life" });

            Console.WriteLine(myQueue.Peek().Author);
            Console.WriteLine(myQueue.Dequeue().Author);
            Console.WriteLine(myQueue.Dequeue().Author);

            // Stack, like Pringles (LIFO) Last-In First-Out
            var pringles = new Stack<string>();
            pringles.Push("Sour Cream and Onion");
            pringles.Push("Cheddar");
            pringles.Push("Jalapenio");

            //Console.WriteLine(pringles.Peek());
            //Console.WriteLine(pringles.Pop());
            //Console.WriteLine(pringles.Pop());
            //Console.WriteLine(pringles.Pop());

            foreach (var pringle in pringles)
            {
                Console.WriteLine(pringle);
            }

            Console.WriteLine(pringles.Pop());
            Console.WriteLine(pringles.Pop());
            Console.WriteLine(pringles.Pop());

            Something1();
            Something2();
            Something3();
        }

        public static void Something1()
        {

        }

        public static void Something2()
        {
            Something3();
        }

        public static void Something3()
        {

        }
    }

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}
