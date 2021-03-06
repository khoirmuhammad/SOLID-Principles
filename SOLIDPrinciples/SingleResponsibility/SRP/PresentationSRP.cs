using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility.SRP
{
    public class PresentationSRP
    {
        //DatabaseManager db = new DatabaseManager();
        private readonly IDatabaseManager db;
        public PresentationSRP()
        {
            db = new DatabaseManager();
        }

        public void RegisterEmployee()
        {
            try
            {
                Employee customer = new Employee
                {
                    Id = 1,
                    Name = "Muhammad Khoirudin",
                    Email = "muhammad.khoiruidn@solid.com",
                    Level = "Senior Developer"
                };

                ShowEmployee();
                Console.WriteLine("-----------------BEFORE SAVING--------------------");

                db.SaveEmployee(customer);

                EmailService.SentEmail(customer);

                Console.WriteLine("------------------AFTER SAVING-------------------");
                ShowEmployee();
            }
            catch (Exception ex)
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
    }
}
