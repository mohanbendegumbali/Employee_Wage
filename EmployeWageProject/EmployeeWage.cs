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
        public void switchcase()
        {
            int dailyempwage = 0, emphr = 0;
            int empcheck = random.Next(0, 3);
            switch (empcheck)
            {
                case FULL_TIME:
                    dailyempwage = WAGE_PER_HR * emphr;
                    Console.WriteLine(" Emp Wage for full day is " + dailyempwage);
                    break;
                case PART_TIME:
                    dailyempwage = WAGE_PER_HR * emphr;
                    Console.WriteLine(" Emp Wage for half day is " + dailyempwage);
                    break;
                default:
                    emphr = 0;
                    Console.WriteLine(" Emp is absent ");
                    break;
            }

        }

    }
}
