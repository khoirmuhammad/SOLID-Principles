using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubstitution.LSP
{
    public abstract class BaseSalaryLSP
    {
        protected readonly int _salary;

        public BaseSalaryLSP(int salary)
        {
            _salary = salary;
        }

        public abstract int GetSalary();
    }
}
