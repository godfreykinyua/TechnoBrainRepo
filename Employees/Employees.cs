using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    public class Employees
    {
        public string EmployeeID { get; set; }
        public string ManagerID { get; set; }
        public int Salary { get; set; }

      public Employees(string employeeID,string managerID,int salary)
        {
            EmployeeID = employeeID;
            ManagerID = managerID;
            Salary = salary;
        }

        public Employees(int salary)
        {
            bool sal = int.TryParse("123", out salary);
            if (sal == false)
            {
                throw new ArgumentException("Salary cannot be a string");
            }
        }



    }
    
}
