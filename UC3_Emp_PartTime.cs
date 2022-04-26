using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC3_Emp_PartTime
    {
        public void Emp_PartTime()
        {
            int WagePerHr = 20, FullDayHr = 8;
            int DailyWage = WagePerHr * FullDayHr;
            Console.WriteLine("Enter vlaue 0 for PartTime and 1 for FullTime");
            int isPartTime = int.Parse(Console.ReadLine());
            if(isPartTime==0)
            {
                Console.WriteLine("PartTime employee daily wage is: " + DailyWage/2);
            }
            else
                Console.WriteLine("FullTime employee daily wage is: " + DailyWage);


        }
    }
}
