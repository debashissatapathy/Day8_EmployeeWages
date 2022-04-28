using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC7_ComputeWage
    {
        public const int IsFullTime = 1;
        public const int IsPartTime =2;
        public const int EmpRatePerHr = 20;
        
        public  static int Compute_Wage()
        {
            int WagePerHr = 20, DayInMonth = 20, HrInMonth = 100;
            int fullTimeWorkingHr = 8;
            int partTimeWorkingHr = 4;
            int DailyWage, Monthly_Wage = 0, day_Count = 1;
            Random random=new Random();
            int chk_EMp = random.Next(0,3);
            switch (chk_EMp)
            {
                case 0:
                    while (HrInMonth > 0 && (HrInMonth / fullTimeWorkingHr) >= 0 && day_Count <= DayInMonth)
                    {
                        DailyWage = WagePerHr * fullTimeWorkingHr;
                        Monthly_Wage += DailyWage;
                        Console.Write("\nFullTime employee " + day_Count + "st day wage is: " + DailyWage + "."
                            + " and monthly salary till date is " + Monthly_Wage + "\n");
                        HrInMonth -= fullTimeWorkingHr;
                        day_Count++;
                    }
                    break;
                case 1:
                    while (HrInMonth > 0 && (HrInMonth / partTimeWorkingHr) >= 0 && day_Count <= DayInMonth)
                    {
                        DailyWage = WagePerHr * partTimeWorkingHr;
                        Monthly_Wage += DailyWage;
                        Console.Write("\nPartTime employee " + day_Count + "st day wage is: " + DailyWage + "."
                            + " and monthly salary till date is " + Monthly_Wage + "\n");
                        HrInMonth -= partTimeWorkingHr;
                        day_Count++;
                    }
                    break;
                case 3:
                    Console.Write("EMployee is absent.");
                    break;

            }
            
            Console.WriteLine("total Emp Wage: " + Monthly_Wage);
            return Monthly_Wage;

        }
       
         
    }
}



