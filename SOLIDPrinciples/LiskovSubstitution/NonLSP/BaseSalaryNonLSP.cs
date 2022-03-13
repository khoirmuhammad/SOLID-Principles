using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitution.NonLSP
{
    public class BaseSalaryNonLSP
    {
        protected readonly int _salary;

        public BaseSalaryNonLSP(int salary)
        {
            _salary = salary;
        }

        public virtual int GetSalary()
        {
            return _salary;
        }
    }
}
