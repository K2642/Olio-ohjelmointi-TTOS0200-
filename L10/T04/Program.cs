using System;
using System.Collections.Generic;
using System.IO;

namespace T04
{
    class Program
    {
        private static double floatnumber;
        private static int realnumber;

        static void Main(string[] args)
        {
            List<int> realnumbers = new List<int>();
            List<double> floatnumbers = new List<double>();
            string intfilename = "T2Integers.txt";
            string doublefilename = "T2Doubles.txt";
            string input = "";
            Boolean isnumber = true;
            do
            {


                Console.Write("Give a number (enter or not a number ends): ");
                input = Console.ReadLine();

                if (int.TryParse(input, out realnumber)) realnumbers.Add(realnumber);
                else if (double.TryParse(input, out floatnumber)) floatnumbers.Add(floatnumber);
                else isnumber = false;


            } while (isnumber);

            Console.WriteLine("Contents of {0}", intfilename);
            foreach (int i in realnumbers) Console.WriteLine(i);
            Console.WriteLine("Contents of {0}", doublefilename);
            foreach (double d in floatnumbers) Console.WriteLine(d.ToString(".0#################"));
            Console.WriteLine("Press any key to store in file");
            Console.ReadKey();
            Console.WriteLine("Great! Let's save them to file!");
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(intfilename);
                foreach (int number in realnumbers)
                {
                    outputFile.WriteLine(number);
                }
                outputFile.Close();
                outputFile = new System.IO.StreamWriter(doublefilename);
                foreach (double number in floatnumbers)
                {
                    outputFile.WriteLine(number.ToString(".0#################"));
                }

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
            Console.ReadKey();
        }
    }
}