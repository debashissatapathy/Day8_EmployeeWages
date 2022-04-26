using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC6_Condition
    {
        public void Emp_Condition()
        {
            int  WagePerHr = 20, DayInMonth=20, HrInMonth=100;
            int fullTimeWorkingHr = 8;
            int partTimeWorkingHr = 4;
            int DailyWage, Monthly_Wage=0, day_Count = 1;
            Console.WriteLine("\nEnter vlaue 0 for FullTime, 1 for PartTime and 2 for Absent");
            int chk_EMp = int.Parse(Console.ReadLine());
            switch (chk_EMp)
            {
                case 0:
                    while (HrInMonth > 0 && (HrInMonth /fullTimeWorkingHr) >= 0 && day_Count <= DayInMonth)
                    {
                        DailyWage = WagePerHr * fullTimeWorkingHr;
                        Monthly_Wage += DailyWage;
                        Console.Write("\nFullTime employee " + day_Count + "st day wage is: " + DailyWage + "."
                            + " and monthly salary till date is " + Monthly_Wage);
                        HrInMonth -= fullTimeWorkingHr;
                        day_Count++;
                    }
                    break;
                case 1:
                    while (HrInMonth > 0 && (HrInMonth/partTimeWorkingHr) >=0 && day_Count<=DayInMonth)
                    {
                        DailyWage = WagePerHr * partTimeWorkingHr;
                        Monthly_Wage += DailyWage;
                        Console.Write("\nPartTime employee " + day_Count + "st day wage is: " + DailyWage + "." 
                            + " and monthly salary till date is "+ Monthly_Wage);
                        HrInMonth -= partTimeWorkingHr;
                        day_Count++;
                    }
                    break;
                case 3:
                    Console.Write("EMployee is absent.");
                    break;
                
            }

        }        
    }
}
