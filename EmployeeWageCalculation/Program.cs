﻿using System;
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
            const int MAX_WORKING_DAYS = 20;
            const int MAX_WORKING_HRS = 100;
            Random random = new Random();
            int dailyWage = 0;
            int empHrs = 0;
            int totalWage = 0;
            int day = 1, workingHrs = 0;

            while (day<= MAX_WORKING_DAYS && workingHrs<= MAX_WORKING_HRS)
            {

                int randomInput = random.Next(0, 3);


                switch (randomInput)
                {
                    case Full_Time:

                        Console.WriteLine("FullTime Employee is Presemt");
                        empHrs = 8;
                        break;

                    case Part_Time:

                        Console.WriteLine("PartTime Employee is Presemt");
                        empHrs = 4;
                        break;

                    default:

                        Console.WriteLine("Employee is Absent");
                        empHrs = 0;
                        break;

                }
                dailyWage = Emp_Rate_Per_Hr * empHrs;
                Console.WriteLine("Daily Wage for day {0} is: {1}",day,dailyWage);
                //totalWage = totalWage + dailyWage;
                totalWage += dailyWage;
                day++;
                workingHrs = workingHrs + empHrs;   

            }
            Console.WriteLine();
            Console.WriteLine("Total Wage for {0} Days is:{1} and Hrs is:{2}", day, totalWage, workingHrs);
            Console.ReadLine();
        }
    }
}
