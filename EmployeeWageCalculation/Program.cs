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
            
            const int Full_Time = 1;
            const int Part_Time = 2;
            const int Emp_Rate_Per_Hr = 20;
            Random random = new Random();
            int randomInput = random.Next(0, 3);
            int empHrs = 0;
            int totalWage = 0;


            if (randomInput == Full_Time)
            {
                Console.WriteLine("FullTime Employee is Presemt");
                empHrs = 8;
                
            }
            else if (randomInput == Part_Time)
            {
                Console.WriteLine("PartTime Employee is Presemt");
                empHrs = 4;

            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
              
            }
            totalWage = Emp_Rate_Per_Hr * empHrs;
            Console.WriteLine("Daily Wage is: " + totalWage);
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
