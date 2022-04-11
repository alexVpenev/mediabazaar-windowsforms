using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Shelf : Product
    {
        private int shelfID;
        private int limit;
        private int noOfProducts;

        public Shelf(int shelfID)
        {
            this.shelfID = shelfID;
        }

        public Shelf(int shelfID, int limit, int noOfProducts, string Model) : base(Model)
        {
            this.shelfID = shelfID;
            this.limit = limit;
            this.noOfProducts = noOfProducts;
        }

    }
}
