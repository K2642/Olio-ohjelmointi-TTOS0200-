using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    public class Club
    {
        public string Name { get; set; }
        public string City { get; set; }
        public List<Player> Players { get; set; }
        public Club(string name, string city)
        {
            Name = name;
            City = city;
            Players = new List<Player>();
        }

        public void AddPlayer(string surname, string firstname, string position, char hand)
        {
            Players.Add(new Player(surname, firstname, position, hand));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Player item in Players)
            {
                sb.Append("\n" + item.ToString());
            }
            return "Club information:\nName:" + Name + "\nCity: " + City + "\nPlayers: \n--------------------\n" + sb.ToString(); ;
        }
    }
}