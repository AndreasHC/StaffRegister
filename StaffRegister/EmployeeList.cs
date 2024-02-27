using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRegister
{
    internal class EmployeeList
    {
        private List<Employee> employees;
        public EmployeeList()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee e)
        {
            employees.Add(e);
        }

        public string TextRepresentation()
        {
            string buffer = string.Empty;
            foreach (Employee e in employees)
            {
                buffer += e.TextRepresentation() + "\n";
            }
            return buffer;
        }
    }
}
