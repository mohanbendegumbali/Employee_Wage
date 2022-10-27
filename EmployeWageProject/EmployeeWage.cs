using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageProject
{
    public class EmployeeWage
    {

        const int WAGE_PER_HR = 20, FULL_DAY_HR = 8, IS_PRESENT = 1, FULL_TIME = 0, PART_TIME = 1, HALF_DAY_HR = 4, MONTH = 20;
        Random random = new Random();
        public void Attendance()
        {

            int empcheck = random.Next(0, 2);
            if (empcheck == IS_PRESENT)
                Console.WriteLine(" Emp is present");
            else
                Console.WriteLine(" Emp is absent");
        }
        public void Empwage()
        {
            int dailyempwage = 0, emphr = 0;
            for (int i = 0; i < 20 && emphr < 100; i++)
            {
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case FULL_TIME:
                        emphr += FULL_DAY_HR;
                        break;
                    case PART_TIME:
                        emphr += HALF_DAY_HR;
                        break;
                    default:
                        emphr = 0;
                        break;
                }
            }
            dailyempwage = WAGE_PER_HR * emphr;
            Console.WriteLine(" Emp Wage for month is " + dailyempwage);

        }


    }
}
