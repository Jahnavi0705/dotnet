﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelLoopforBreak
{
    public delegate bool EligibleToPromotion(Employee EmployeeToPromotion);
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        public static void PromoteEmployee(List<Employee> lstEmployees, EligibleToPromotion IsEmployeeEligible)
        {
            foreach (var item in lstEmployees)
            {
                if (IsEmployeeEligible(item))
                {
                    Console.WriteLine("Employee {0} is promoted", item.Name);
                }
            }
        }
    }
    internal class RealTimeEmployee
    {
        static void Main6(string[] args)
        {
            Employee employee1 = new Employee() { ID = 101, Name = "Jahnavi", Gender = "Female", Experience = 10, Salary = 15000 };
            Employee employee2 = new Employee() { ID = 102, Name = "Yasaswini", Gender = "Female", Experience = 10, Salary = 50000 };
            Employee employee3 = new Employee() { ID = 103, Name = "Vaishnavi", Gender = "Female", Experience = 10, Salary = 20000 };
            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(employee1);
            employeesList.Add(employee2);
            employeesList.Add(employee3);
            EligibleToPromotion eligibleToPromotion = new EligibleToPromotion(RealTimeEmployee.Promote);
            Employee.PromoteEmployee(employeesList, eligibleToPromotion);

        }
        public static bool Promote(Employee employee)
        {
            if (employee.Salary > 10000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
