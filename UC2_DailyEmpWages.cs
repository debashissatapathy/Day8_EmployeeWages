using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC2_DailyEmpWages
    {
        public void Emp_Wages()
        {
            int WagePerHr = 20, FullDayHr = 8;
            int DailyWage = WagePerHr * FullDayHr;
            Console.WriteLine(DailyWage);
            
        }
    }
}
