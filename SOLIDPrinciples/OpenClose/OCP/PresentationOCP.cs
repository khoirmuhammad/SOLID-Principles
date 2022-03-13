using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClose.OCP
{
    public class PresentationOCP
    {
        BaseSalary salary = null;
        public void GetSalaryEmployeeByLevel()
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Muhammad Khoirudin";
            emp.level = Level.SeniorDeveloper;

            if (emp.level.Equals(Level.JuniorDeveloper))
            {
                salary = new JuniorDeveloperSalary();
            }
            else if (emp.level.Equals(Level.SeniorDeveloper))
            {
                salary = new SeniorDeveloperSalary();
            }

            emp.Salary = salary != null ? salary.SetSalary() : 0;

            string level = Enum.GetName(typeof(Level), emp.level);

            Console.WriteLine($"{emp.Name} - {level} - {emp.Salary}");
        }
    }
}
