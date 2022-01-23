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
             

            if (randomInput == FullTimeEmployee)
            {
                Console.WriteLine("Employee is Presemt");
                
            }
            else
            {
                Console.WriteLine("Employee is Absent");
              
            }
            Console.ReadLine();
        }
    }
}
