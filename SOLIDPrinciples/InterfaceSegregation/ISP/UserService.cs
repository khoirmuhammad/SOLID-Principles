using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregation.ISP
{
    public class UserService : IBasicDatabaseOperation
    {
        public void DeleteData()
        {
            Console.WriteLine("User Delete");
        }

        public void InsertData()
        {
            Console.WriteLine("User Insert");
        }

        public void SelectData()
        {
            Console.WriteLine("User Select");
        }

        public void UpdateData()
        {
            Console.WriteLine("User Update");
        }
    }
}
