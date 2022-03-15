using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility
{
    public class DatabaseManager : IDatabaseManager
    {
        private readonly IEmployeeData _employeeData;
        public DatabaseManager()
        {
            _employeeData = new EmployeeData();
        }
        public List<Employee> SelectEmployees()
        {
            return _employeeData.SelectEmployees();
        }

        public void SaveEmployee(Employee employee)
        {
            _employeeData.SaveEmployee(employee);
        }
    }
}
