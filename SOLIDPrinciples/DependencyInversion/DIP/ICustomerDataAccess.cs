using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.DependencyInversion.DIP
{
    public interface ICustomerDataAccess
    {
        List<Customer> SelectCustomers();
    }
}
