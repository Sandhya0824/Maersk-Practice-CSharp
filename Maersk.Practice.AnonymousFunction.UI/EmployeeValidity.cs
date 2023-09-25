using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maersk.Practice.AnonymousFunction.UI
{
    public class EmployeeValidity : IEmployeeValidity
    {
        public bool IsEmployeeValid(IEmployee employee)
        {
            return employee.Salary == 400000;
        }
    }
}
