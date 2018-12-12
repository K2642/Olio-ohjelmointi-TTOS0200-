using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] values = new double[] { 2.0, 1, 3.1 };
            ArrayCalcs laskuri = new ArrayCalcs();

            Console.WriteLine(ArrayCalcs.Sum(values));
            Console.WriteLine(ArrayCalcs.Average(values));
            Console.WriteLine(ArrayCalcs.Min(values));
            Console.WriteLine(ArrayCalcs.Max(values));
            Console.ReadKey();
        }
    }

    public class ArrayCalcs
    {
        public ArrayCalcs() { }

        public static double Sum(double[] a)
        {
            double sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
        public static double Average(double[] a)
        {
            double sum = Sum(a);
            return sum / a.Length;
        }
        public static double Min(double[] a)
        {
            double min = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static double Max(double[] a)
        {
            double max = a[0];

            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }
    }
}