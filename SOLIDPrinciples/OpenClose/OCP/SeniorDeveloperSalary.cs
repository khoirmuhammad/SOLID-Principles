using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClose.OCP
{
    public class SeniorDeveloperSalary : BaseSalary
    {
        public override double SetSalary()
        {
            return 10000000;
        }
    }
}
