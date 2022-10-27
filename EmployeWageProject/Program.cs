using EmployeWageProject;
using System;

namespace EmployeeWageProject
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Employee Problem Statement");
          EmployeeWage employee = new EmployeeWage();
          employee.Attendance();
        }
    }
}