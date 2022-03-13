using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClose.NonOCP
{
    public class PresentationNonOCP
    {
        public void GetSalaryEmployeeByLevel()
        {
            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Muhammad Khoirudin";
            emp.level = Level.SeniorDeveloper;

            emp.Salary = SetSalary(emp.level);

            string level = Enum.GetName(typeof(Level), emp.level);

            Console.WriteLine($"{emp.Name} - {level} - {emp.Salary}");
        }

        private double SetSalary(Level level)
        {
            if (level.Equals(Level.JuniorDeveloper))
            {
                return 7000000;
            }
            else if (level.Equals(Level.SeniorDeveloper))
            {
                return 10000000;
            }
            else
            {
                return 0;
            }
        }
    }
}
