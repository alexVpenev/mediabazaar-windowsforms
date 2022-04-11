using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    interface IConstraintChecker
    {
        int Check(DateTime date);
        bool Check(int id, DateTime date);
    }
}
