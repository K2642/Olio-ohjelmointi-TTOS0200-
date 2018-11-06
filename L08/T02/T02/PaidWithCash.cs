using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class PaidWithCash : ITransaction
    {
        private float amount;
        public int BillNumber { get; }
        public string Date { get; }
        private static int counter = 0;
        private static float totalAmount = 0;

        public PaidWithCash(float sum, string date)
        {
            amount = sum;
            counter++;
            BillNumber = counter;
            totalAmount += sum;
            Date = date;
        }

        public string ShowTransaction()
        {
            return "Paid with cash: billnumber " + BillNumber + " date " + Date + " amount " + amount;
        }

        public float GetAmount()
        {
            return amount;
        }

        public float ShowCash()
        {
            return totalAmount;
        }
    }
}
