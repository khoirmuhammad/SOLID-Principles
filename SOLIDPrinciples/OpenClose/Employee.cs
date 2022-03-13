using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.OpenClose
{
    public enum Level
    {
        JuniorDeveloper,
        SeniorDeveloper
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Level level { get; set; }
        public double Salary { get; set; }
    }
}
