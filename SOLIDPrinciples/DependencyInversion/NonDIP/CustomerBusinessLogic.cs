using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversion.NonDIP
{
    public class CustomerBusinessLogic
    {
        CustomerDataAccess customerDA = new CustomerDataAccess();

        public void SelectCustomer()
        {
            List<Customer> customers = customerDA.SelectCustomers();

            foreach(Customer customer in customers)
            {
                Console.WriteLine(string.Format("ID {0}, Name {1}", customer.Id, customer.Name));
            }
        }
    }
}
