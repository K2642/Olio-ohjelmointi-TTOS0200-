using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07plus2
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            Dictionary<string, Person> personsDict = new Dictionary<string, Person>();
            List<string> foundItems = new List<string>();

            int count = 10000;
            int i = 0;
            long ms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long foundms = 0;

            for (i = 0; i <= count; i++)
            {
                bool newKey = true;
                string key = RandString(4);
                string name = key + RandString(10);

                foreach (string person in personsDict.Keys)
                {
                    if (key == person)
                    {
                        i--;
                        newKey = false;
                        break;
                    }
                }

                if (newKey == true)
                    personsDict.Add(key, new Person { FirstName = key, LastName = name });


            }
            foundms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            var randomPerson = personsDict.ToList()[rand.Next(personsDict.Count)];

            Console.WriteLine("Dictionary collection:\n- Adding time : {0} ms\n- Persons count : {1}\n- Random person : {2} {3}\n", (foundms - ms), count, randomPerson.Value.FirstName, randomPerson.Value.LastName);

            

            i = 0;
            foundms = 0;
            ms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            Console.WriteLine("Finding persons in collection (by firstname):");
            string randString;

            while (i < 1000)
            {
                randString = RandString(4);
                if (personsDict.ContainsKey(randString))
                {
                    var value = personsDict[randString];
                    foundItems.Add("Found person with " + randString + " firstname: " + value.FirstName + " " + value.LastName);
                }
                i++;
            }

            
            foundms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            foreach (string s in foundItems) Console.WriteLine(s);
            Console.WriteLine("\n- Persons tried to find : {0}\n- Total findind time : {1} ms", 1000, (foundms - ms));
        }

        static string RandString(int length)
        {
            string ret = "";
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
            for (int i = 0; i < length; i++)
            {
                ret += chars[rand.Next(chars.Length)];
            }
            return ret;
        }
    }
}
