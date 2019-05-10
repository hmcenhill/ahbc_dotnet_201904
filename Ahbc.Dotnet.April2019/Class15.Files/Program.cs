using System;
using System.IO;

namespace Class15.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            // Static I/O functions

            if (File.Exists("SomeFile.txt"))
            {
                Console.WriteLine("The file exists, so we must delete it");
                File.Delete("SomeFile.txt");
            }

            //File.Create("SomeFile.txt"); // Creates an empty file
            File.WriteAllText("SomeFile.txt", "Hello"); // Creates a file with the provided text
            File.AppendAllText("SomeFile.txt", $"Hello at {DateTime.Now.ToLongTimeString()}"); // Adds this text to the file

            var contents = File.ReadAllText("SomeFile.txt");
            Console.WriteLine(contents);

            if (Directory.Exists("SomeFolder"))
            {
                Console.WriteLine("The directory exists, so we must delete it");
                Directory.Delete("SomeFolder");
            }

            Directory.CreateDirectory("SomeFolder");

            // stream reader / writer
            using (var writer = new StreamWriter("SomeStreamFile.txt"))
            {
                writer.WriteLine("Hello");
                writer.WriteLine("World");
                writer.Flush();
            }

            using (var reader = new StreamReader("SomeStreamFile.txt"))
            {
                while (reader.EndOfStream == false)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
        }
    }
}
