using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitution.NonLSP
{
    public class SeniorDeveloperSalaryNonLSP : BaseSalaryNonLSP
    {
        public SeniorDeveloperSalaryNonLSP(int salary) : base(salary)
        {

        }

        /*
         * if BaseSalary object (base class) is storing SeniorDeveloperSalary (derived class), then behaviour of base class will be replaced with derived class
         */
        public override int GetSalary()
        {
            return _salary + 2000000;
        }
    }
}
