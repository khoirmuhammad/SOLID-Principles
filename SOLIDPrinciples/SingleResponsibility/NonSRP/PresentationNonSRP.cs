using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility.NonSRP
{
    public class PresentationNonSRP
    {
        private readonly IDatabaseManager db;
        public PresentationNonSRP()
        {
            db = new DatabaseManager();
        }

        public void RegisterEmployee()
        {
            try
            {
                Employee employee = new Employee
                {
                    Id = 1,
                    Name = "Muhammad Khoirudin",
                    Email = "muhammad.khoiruidn@solid.com",
                    Level = "Senior Developer"
                };

                ShowEmployee();
                Console.WriteLine("-----------------BEFORE SAVING--------------------");

                db.SaveEmployee(employee);

                SentEmail(employee);

                Console.WriteLine("------------------AFTER SAVING-------------------");
                ShowEmployee();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private void ShowEmployee()
        {
            foreach (var item in db.SelectEmployees())
            {
                Console.WriteLine($"{item.Name} - {item.Level}");
            }
        }

        private void SentEmail(Employee employee)
        {
            Console.WriteLine("Non SRP");
            Console.WriteLine($"Email To : {employee.Email}");
            Console.WriteLine("Email sent successfully");
        }
    }
}
