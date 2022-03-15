using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregation.ISP
{
    public class EmployeeServiceISP : IBasicDatabaseOperation, IBulkInsert
    {
        public void BulkInsertData()
        {
            Console.WriteLine("Employee Bulk Insert");
        }

        public void DeleteData()
        {
            Console.WriteLine("Employee Delete");
        }

        public void InsertData()
        {
            Console.WriteLine("Employee Insert");
        }

        public void SelectData()
        {
            Console.WriteLine("Employee Select");
        }

        public void UpdateData()
        {
            Console.WriteLine("Employee Update");
        }
    }
}
