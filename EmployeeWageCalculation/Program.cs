using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int FullTimeEmployee = 1;
            int randomInput = random.Next(0, 2);
            int empRatePerHr = 20;
            int empHrs = 0;
            int totalWage = 0;


            if (randomInput == FullTimeEmployee)
            {
                Console.WriteLine("Employee is Presemt");
                empHrs = 8;
                
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
              
            }
            totalWage = empRatePerHr * empHrs;
            Console.WriteLine("Daily Wage is: " + totalWage);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
