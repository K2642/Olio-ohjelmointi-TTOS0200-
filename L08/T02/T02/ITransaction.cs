using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02
{
    interface ITransaction
    {
        // interface members 
        string ShowTransaction();
        float GetAmount();
    }
}