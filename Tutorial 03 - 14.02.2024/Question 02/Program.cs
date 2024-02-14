using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        public class Employee
        {
            private int employeeID;
            private string fullName;
            private double salary;

            public int EmployeeID
            {
                get { return employeeID; }
            }

            public string FullName
            {
                get { return fullName; }
                set { fullName = value; }
            }

            public double Salary
            {
                get { return salary; }
            }

            public Employee(int empId, string empName, double empSalary)
            {
                employeeID = empId;
                fullName = empName;
                salary = empSalary;
            }

            public void DisplayEmployeeInfo()
            {
                Console.WriteLine($"\nEmployee ID: {EmployeeID}");
                Console.WriteLine($"Employee Name: {FullName}");
                Console.WriteLine($"Employee Salary: ${Salary}");
            }
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee(101, "John Doe", 50000);

            Console.WriteLine($"Employee ID: {employee.EmployeeID}");

            Console.WriteLine("\nCurrent Employee Information: ");
            employee.DisplayEmployeeInfo();

            employee.FullName = "John Smith";

            // employee.Salary = 100000;
            // Since the salary property is read-only, it cannot be modified.
            // If you try to modify it, it will result in a compilation error.

            Console.WriteLine("\nUpdated Employee Information: ");
            employee.DisplayEmployeeInfo();

            Console.ReadLine();
        }
    }
}
