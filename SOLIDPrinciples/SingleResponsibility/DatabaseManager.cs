using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class DatabaseManager
    {
        Employee emp = new Employee();
        public List<Employee> SelectEmployees()
        {
            return emp.SelectEmployees();
        }

        public void SaveCustomer(Employee employee)
        {
            emp.SaveEmployee(employee);
        }
    }
}
