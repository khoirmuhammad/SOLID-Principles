using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.SingleResponsibility.SRP
{
    public class EmailService
    {
        public static void SentEmail(Employee customer)
        {
            Console.WriteLine("SRP");
            Console.WriteLine($"Email To : {customer.Email}");
            Console.WriteLine("Email sent successfully");
        }
    }
}
