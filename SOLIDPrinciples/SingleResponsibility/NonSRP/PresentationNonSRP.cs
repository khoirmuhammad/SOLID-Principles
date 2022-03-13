using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility.NonSRP
{
    public class PresentationNonSRP
    {
        DatabaseManager db = new DatabaseManager();

        public void RegisterCustomer()
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

                db.SaveCustomer(customer);

                SentEmail(customer);

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

        private void SentEmail(Employee customer)
        {
            Console.WriteLine("Non SRP");
            Console.WriteLine($"Email To : {customer.Email}");
            Console.WriteLine("Email sent successfully");
        }
    }
}
