using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    class StringModifier
    {
        public string CapitalLetters(string sentence)
        {
            return sentence.ToUpper();
        }
        public string SmallLetters(string sentence)
        {
            return sentence.ToLower();
        }
        public string Title(string sentence)
        {
            return char.ToUpper(sentence[0]) + sentence.Substring(1);
        }
        public string Reverse(string sentence)
        {
            char[] charArray = sentence.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}