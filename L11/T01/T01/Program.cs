using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    public class Program
    {

        public delegate string StringHandler(string Sentence);

        static void Main(string[] args)
        {

            string sentence = "";
            int selection;
            Boolean validSelection = true;

            StringModifier modifier = new StringModifier();

            StringHandler Clause = new StringHandler(modifier.CapitalLetters);

            while (validSelection)
            {
                Console.WriteLine("Anna käsiteltävä merkkijono ja paina enteriä tai paina pelkästään enteriä lopettaaksesi");
                sentence = Console.ReadLine();
                if (sentence.Length == 0) break;
                Console.WriteLine("Valitse haluamasi käsittely, voit antaa useamman käsittelyn kerralla yhtenä numerosarjana esim. '123'. Paina lopuksi enteriä");
                Console.WriteLine("1. Isoiksi kirjaimiksi");
                Console.WriteLine("2. Pieniksi kirjaimiksi");
                Console.WriteLine("3. Otsikoksi");
                Console.WriteLine("4. Palindromiksi");
                Console.WriteLine("0. Lopetus");

                validSelection = int.TryParse(Console.ReadLine(), out int parsedSelection);
                selection = parsedSelection;
                if (!validSelection)
                {
                    Console.WriteLine("Virheellinen valinta!");
                    validSelection = true;
                    continue;
                }

                int[] result = parsedSelection.ToString().Select(c => Convert.ToInt32(c.ToString())).ToArray();

                foreach (int number in result)
                {
                    switch (number)
                    {
                        case 0:
                            validSelection = false;
                            break;
                        case 1:
                            Clause = new StringHandler(modifier.CapitalLetters);
                            break;
                        case 2:
                            Clause = new StringHandler(modifier.SmallLetters);
                            break;
                        case 3:
                            Clause = new StringHandler(modifier.Title);
                            break;
                        case 4:
                            Clause = new StringHandler(modifier.Reverse);
                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(Clause(sentence));
                }
            }
        }
    }


}
