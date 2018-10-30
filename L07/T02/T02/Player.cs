using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    public class Player
    {
        public string Surname { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public char Hand { get; set; }
        public Player(string surname, string firstname, string pos, char hand)
        {
            Surname = surname;
            FirstName = firstname;
            Position = pos;
            Hand = hand;
        }

        public override string ToString()
        {
            return "\nName: " + FirstName + " " + Surname + "\nPosition: " + Position + "\nHand: " + Hand;
        }
    }
}