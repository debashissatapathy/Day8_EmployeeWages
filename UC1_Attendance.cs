using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWages
{
    class UC1_Attendance
    {
        public void Emp_Attendance()
        {
            Random check = new Random();
            int i = check.Next(2);
            if (i == 0)
            {
                Console.WriteLine("Employee is absent");

            }
            else
                Console.WriteLine("Employee is Present");

        }
    }
}
