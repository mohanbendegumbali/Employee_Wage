using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageProject
{
    public class EmployeeWage
    {

        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, IS_PRESENT = 1, FULL_TIME = 0, PART_TIME = 1, HALF_DAY_HR = 4;
        Random random = new Random();
        public void Attendance()
        {

            int empcheck = random.Next(0, 2);
            if (empcheck == IS_PRESENT)
                Console.WriteLine(" Emp is present");
            else
                Console.WriteLine(" Emp is absent");
        }
        public void EmpWage()
        {
            int dailyempwage = 0, emphr = 0;
            int empcheck = random.Next(0, 2);
            if (empcheck == FULL_TIME)
                emphr = FULL_DAY_HR;
            else
                emphr = 0;
            dailyempwage = WAGE_PER_HR * emphr;
            Console.WriteLine(" Daily Wage of Employee" + dailyempwage);
        }

    }
}
