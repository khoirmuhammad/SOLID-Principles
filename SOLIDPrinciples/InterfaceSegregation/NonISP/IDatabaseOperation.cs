using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.InterfaceSegregation.NonISP
{
    public interface IDatabaseOperation
    {
        void SelectData();
        void InsertData();
        void UpdateData();
        void DeleteData();
        void BulkInsertData();
    }
}
