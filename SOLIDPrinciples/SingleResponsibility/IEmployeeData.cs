using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility
{
    public interface IEmployeeData
    {
        List<Employee> SelectEmployees();
        void SaveEmployee(Employee employee);
    }
}
