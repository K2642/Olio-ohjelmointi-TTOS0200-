using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Teacher";
            employee.Salary = 1200;
            Console.WriteLine(employee.ToString());


            Boss boss = new Boss();
            boss.Name = "Jussi Jurkka";
            boss.Profession = "Head Of Institute";
            boss.Salary = 9000;
            boss.Car = "Audi";
            boss.Bonus = 5000;
            Console.WriteLine(boss.ToString());

            Employee employee1 = new Employee();
            employee.Name = "Kirsi Kernel";
            employee.Profession = "Principal Teacher";
            employee.Salary = 2200;
            Console.WriteLine(employee.ToString());







        }
    }
}