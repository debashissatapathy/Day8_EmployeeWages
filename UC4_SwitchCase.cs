using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC4_SwitchCase
    {
        public void Emp_Swichcase()
        {
            int WagePerHr = 20, FullDayHr = 8;
            int DailyWage = WagePerHr * FullDayHr;
            Console.WriteLine("\nEnter vlaue 0 for PartTime and 1 for FullTime");
            int isPartTime = int.Parse(Console.ReadLine());
            switch(isPartTime)
            {
                case 0:
                    Console.WriteLine("PartTime employee daily wage is: " + DailyWage/2);
                    break;
                case 1:
                    Console.WriteLine("FullTime employee daily wage is: " + DailyWage);
                    break;
            }
            
                


        }
    }
}
