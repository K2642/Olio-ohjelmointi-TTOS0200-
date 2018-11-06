using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class Program
    {

        static void Main(string[] args)
        {


            PaidWithCard card1 = new PaidWithCard(200.52F, "0001-0002", DateTime.Now.ToShortDateString());

            PaidWithCard card2 = new PaidWithCard(50.15F, "0001-0003", DateTime.Now.ToShortDateString());



            PaidWithCash cash1 = new PaidWithCash(50, DateTime.Now.ToShortDateString());

            PaidWithCash cash2 = new PaidWithCash(120, DateTime.Now.ToShortDateString());


            Console.WriteLine(card1.ShowTransaction());
            Console.WriteLine(card2.ShowTransaction());
            Console.WriteLine("Total money to our bankaccount {0}", card2.ShowBank());

            Console.WriteLine(cash1.ShowTransaction());
            Console.WriteLine(cash2.ShowTransaction());
            Console.WriteLine("Total money in cash {0}", cash2.ShowCash());

            List<ITransaction> transactions = new List<ITransaction>();

            transactions.Add(card1);
            transactions.Add(card2);
            transactions.Add(cash1);
            transactions.Add(cash2);

            float sum = 0;

            foreach (var transaction in transactions)
            {
                sum += transaction.GetAmount();
            }

            Console.WriteLine("Total sales today {0} is {1} EUR\nOhjelma suoritettu onnistuneesti.", DateTime.Now.ToShortDateString(), sum);
        }
    }
}