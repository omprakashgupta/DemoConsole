using DemoConsole.Solid.Dependency_Inversion_Principle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsole.Solid
{
    public class DataAccessFactory
    {
        public static IEmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
}
