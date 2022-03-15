using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class EmployeeData : IEmployeeData
    {
        private List<Employee> _employees;

        public EmployeeData()
        {
            _employees = new List<Employee>();
        }
        public void SaveEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> SelectEmployees()
        {
            return _employees;
        }
    }
}
