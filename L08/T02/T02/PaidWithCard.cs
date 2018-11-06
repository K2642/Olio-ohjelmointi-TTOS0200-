using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    class PaidWithCard : ITransaction
    {
        private float amount;
        public string CardName { get; }
        public string Date { get; }
        private static float TotalAmount = 0;

        public PaidWithCard(float sum, string card, string date)
        {
            amount = sum;
            TotalAmount += sum;
            Date = date;
            CardName = card;
        }

        public string ShowTransaction()
        {
            return "Transaction to bank: charge from card " + CardName + " date " + Date + " amount " + amount;
        }

        public float GetAmount()
        {
            return amount;
        }

        public float ShowBank()
        {
            return TotalAmount;
        }
    }
}