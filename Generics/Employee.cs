using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class Program
    {
        public class sample<T>
        {
            private T data;
            public T value
            {
                get
                {
                    return this.data;
                }
                set
                {
                    this.data = value;
                }
            }

        }
        public class Employee
        {
            public int EmployeeID { get; set; }
            public string EmployeeName { get; set; }
            public string Employeedesignation { get; set; }
            public string EmployeeAddress { get; set; }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee()
            {
                EmployeeID = 101,
                EmployeeName = "Jahnavi",
                Employeedesignation = "Developer",
                EmployeeAddress = "Hyderabad"
            };

            Console.WriteLine("\n");
            Console.WriteLine("Employee Information:-");
            Console.WriteLine(emp.EmployeeID);
            Console.WriteLine(emp.EmployeeName);
            Console.WriteLine(emp.Employeedesignation);
            Console.WriteLine(emp.EmployeeAddress);

        }
    }
    
}
