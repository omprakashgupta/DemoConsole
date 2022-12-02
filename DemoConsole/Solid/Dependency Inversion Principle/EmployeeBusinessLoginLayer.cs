using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Solid.Dependency_Inversion_Principle
{
    public class EmployeeBusinessLoginLayer
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLoginLayer()
        {
            _EmployeeDataAccess = new EmployeeDataAccess();
        }

        public Employee GetEmployeeDetails(int Employee_Id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(Employee_Id);
        }
    }
}
