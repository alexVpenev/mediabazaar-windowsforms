using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Storage
    {
        public List<Product> products;
        public List<Product> productsInfo;
        
        private SQL sql;

        public Storage()
        {
            sql = new SQL();
            products = sql.GetProducts();
            productsInfo = sql.GetShelfIdForProduct();
        }
    }
}
