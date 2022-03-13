using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitution.LSP
{
    public class SeniorDeveloperSalaryLSP : BaseSalaryLSP
    {
        public SeniorDeveloperSalaryLSP(int salary) : base(salary)
        {

        }

        public override int GetSalary()
        {
            return _salary + 2000000;
        }
    }
}
