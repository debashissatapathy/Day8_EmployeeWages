using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC5_MonthlyWages
    {
        public void Emp_MontlyWages()
        {
            int WagePerHr = 20, FullDayHr = 8;
            int DailyWage = WagePerHr * FullDayHr;
            int Monthly_Wage = DailyWage * 20;
            Console.WriteLine("\nEnter vlaue 0 for PartTime and 1 for FullTime");
            int isPartTime = int.Parse(Console.ReadLine());
            switch(isPartTime)
            {
                case 0:
                    Console.Write("\nPartTime employee daily wage is: " + DailyWage / 2);
                    Console.WriteLine(" and Monthly wages is: " + Monthly_Wage/2);
                    break;
                case 1:
                    Console.Write("FullTime employee daily wage is: " + DailyWage);
                    Console.WriteLine(" and Monthly wages is: " + Monthly_Wage);
                    break;
            }
            
                


        }
    }
}
