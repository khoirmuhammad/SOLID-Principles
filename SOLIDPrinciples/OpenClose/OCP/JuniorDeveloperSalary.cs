using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClose.OCP
{
    public class JuniorDeveloperSalary : BaseSalary
    {
        public override double SetSalary()
        {
            return 7000000;
        }
    }
}
