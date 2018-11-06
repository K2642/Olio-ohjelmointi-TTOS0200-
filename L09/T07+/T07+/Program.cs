using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07plus
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

            List<Person> people = new List<Person>();
            List<string> foundItems = new List<string>();

            int count = 10000;
            int i = 0;
            long ms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            long foundms = 0;



            for (i = 0; i <= count; i++)
            {
                people.Add(new Person { FirstName = RandString(4), LastName = RandString(10) });
                if (i == count)
                    foundms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            }

            int randomPerson = rand.Next(count);
            Console.WriteLine("List Collection:\n- Adding time : {0} ms\n- Persons count : {1}\n- Random person : {2} {3}\n", (foundms - ms), count, people[randomPerson].FirstName, people[randomPerson].LastName);


            i = 0;
            foundms = 0;
            ms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            Console.WriteLine("Finding persons in collection (by firstname):");

            while (i < 1000)
            {


                string randString = RandString(4);
                for (int j = 0; j < people.Count; j++)
                {
                    if (people[j].FirstName == randString)
                    {

                        foundItems.Add("- Found person with " + randString + " firstname : " + people[j].FirstName + " " + people[j].LastName);
                        i++;

                    }
                }



            }

            foundms = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            foreach (string s in foundItems) Console.WriteLine(s);
            Console.WriteLine("Persons tried to find : {0}\n- Total findind time : {1} ms", 1000, (foundms - ms));
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