using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Request
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public int Quantity { get; private set; }
        public string Status { get; private set; }

        public Request()
        {

        }
        public Request(string model, int quantity)
        {
            this.Model = model;
            this.Quantity = quantity;
        }
        public Request(int id,string model, int quantity)
        {
            this.Id = id;
            this.Model = model;
            this.Quantity = quantity;
        }
        public Request(int id, string model, int quantity, string status)
        {
            this.Id = id;
            this.Model = model;
            this.Quantity = quantity;
            this.Status = status;
        }

    }
}
