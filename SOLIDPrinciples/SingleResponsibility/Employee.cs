using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Level { get; set; }

        private List<Employee> employees = new List<Employee>();

        public List<Employee> SelectEmployees()
        {
            return employees;
        }

        public void SaveEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
