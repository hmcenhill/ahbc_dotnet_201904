using System;
using System.Collections.Generic;
using System.Linq;

namespace Class8
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Array
            
            //string sentence = "Please excuse my dear aunt sally    ";
            //string[] words = sentence.Trim().Split(' ');
            //foreach (var word in words)
            //{
            //    Console.WriteLine(word);
            //}

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //Console.WriteLine(words[3]);
            //int index = 3;
            //Console.WriteLine(words[index]);
            
            //string[] name = new string[words.Length + 1];
            //for (int i = 0; i < words.Length; i++)
            //{
            //    name[i] = words[i];
            //}

            //name[name.Length - 1] = ".";

            //words.CopyTo(name, 0);
            //Array.Copy(words, name, words.Length);

            //// List

            //var movies = new List<string>();
            //movies.Add("Goonies");
            //movies.Add("Star Wars");
            //movies.Add("Die Hard");
            //movies.Insert(1, "The Shining");
            
            ////movies.RemoveAt(1);
            //movies.RemoveRange(1, 2);
            //// movies.Sort();

            ////Console.WriteLine(movies[1]);
            //foreach (var movie in movies)
            //{
            //    Console.WriteLine(movie);
            //}

            //var sentence2 = "Game of Thrones is on Sunday";
            //var words2 = sentence2.Split(" ");

            //var wordsList2 = new List<string>();
            //wordsList2.AddRange(words2);

            //string[] wordsArray2 = wordsList2.ToArray();
            //List<string> sentence3 = wordsArray2.ToList();

            //// Dictionaries

            //var dictionary = new Dictionary<Guid, string>();
            //dictionary.Add(Guid.NewGuid(), "You did it AK!!!");
            //dictionary[Guid.NewGuid()] = "You did it James";
            //dictionary[Guid.NewGuid()] = "You did it Jason";

            //var key = Guid.NewGuid();
            //dictionary[key] = "You did it Lucero";

            //foreach (var kvp in dictionary)
            //{
            //    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            //}

            //Console.WriteLine(dictionary[key]);

            // Queue (FIFO)
            var queue = new Queue<string>();
            queue.Enqueue("Hello");
            queue.Enqueue("World");

            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            
            // Stack (LIFO)
            var stack = new Stack<string>();
            stack.Push("Hello");
            stack.Push("World");

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());



            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
