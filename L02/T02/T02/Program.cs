﻿using System;
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
            int[] luvut = new int[5];

            for (int i = 0; i < luvut.Length; i++)
            {
                Console.Write("Anna luku: ");
                luvut[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Luvut ovat ");
            for (int j = (luvut.Length - 1); j >= 0; j--)
            {
                Console.Write(luvut[j]);
                if (j != 0) Console.Write(", ");
                if (j == 0) Console.Write(".");
            }
            Console.ReadLine();
        }
    }
}