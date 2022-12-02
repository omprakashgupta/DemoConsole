using DemoConsole.Solid.Dependency_Inversion_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Solid
{
    public class EmployeeDataAccess: IEmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int Employee_Id)
        {
            Employee employee = new Employee
            {
                Employee_Id = Employee_Id,
                Employee_Name = "Philip",
                Department = "Manager",
                Salary = 200000
            };
            return employee;
        }
    }
}
