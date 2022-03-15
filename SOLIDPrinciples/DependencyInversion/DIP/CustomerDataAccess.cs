using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversion.DIP
{
    public class CustomerDataAccess : ICustomerDataAccess
    {
        private List<Customer> _customers = new List<Customer>();

        public CustomerDataAccess()
        {
            _customers.Add(new Customer { Id = 1, Name = "Muhammad Khoirudin" });
        }

        public List<Customer> SelectCustomers()
        {
            return _customers;
        }
    }
}
