using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    class StockRequests
    {
        public List<Request> requests;

        private SQL sql;

        public StockRequests()
        {
            sql = new SQL();
            requests = sql.GetRequests();
        }
    }
}
