using Domain.Models;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class EmployeeService : IEmployeeService
    {
        public int GetFilteredEmployeesCount(DateTime start, DateTime end, double salary)
        {
            Employee[] employees = GetEmployees();

            int count = 0;

            foreach (Employee employee in employees)
            {
                if ((employee.Birthday > start && employee.Birthday < end) && employee.Salary > salary)
                {
                    count++;
                }
            }
            return count;
        }

        private Employee[] GetEmployees()
        {
            Employee employee1 = new Employee(DateTime.Now.AddDays(20));
            employee1.Salary = 5000;
            Employee employee2 = new Employee(DateTime.Now.AddDays(15));
            employee1.Salary = 7500;
            Employee employee3 = new Employee(DateTime.Now.AddDays(-20));
            employee1.Salary = 800;
            Employee employee4 = new Employee(DateTime.Now.AddDays(-10));
            employee1.Salary = 1000;
            Employee employee5 = new Employee(DateTime.Now);
            employee1.Salary = 6000;

            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };

            return employees;
        }
    }
}
