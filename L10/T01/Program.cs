using System;
using System.IO;
using System.Collections.Generic;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's ask user a bunch of lines!");
            string input = "";
            List<string> inputs = new List<string>();
            do
            {
                Console.Write("Give a text line (enter ends): ");
                input = Console.ReadLine();
                if (input.Length > 0) inputs.Add(input);

            } while (input.Length != 0);
            Console.WriteLine("Great! Let's save them to file!");
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter("names.txt");
                foreach (string line in inputs)
                    outputFile.WriteLine(line);
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Can't open file for writing (UnauthorizedAccessException)");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Opened stream is null (ArgumentNullException)");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Opened stream is not writable (ArgumentException)");
            }
            catch (IOException)
            {
                Console.WriteLine("An IO error happend (IOException)");
            }
            catch (Exception)
            {
                Console.WriteLine("Some other exception happend (Exception)");
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                    Console.WriteLine("Lines saved to file! Stream to file closed.");
                }
            }

            Console.WriteLine("Let's open stream to file again and try to read those lines we wrote!");
            Console.ReadKey();
            try
            {
                string[] lines = System.IO.File.ReadAllLines("names.txt");
                foreach (string line in lines) Console.WriteLine(line);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            Console.ReadKey();
        }
    }
}