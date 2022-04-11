using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{
    public class Product
    {
        public string Model { get; private set; }
        public string BrandName { get; private set; }
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public double Width { get; private set; }
        public string Description { get; private set; }
        public Department Category { get; private set; }
        public double Price { get; private set; }
        public int AisleNumber { get; private set; }
        public int LocationLeft { get; private set; }
        public int LocationRight { get; private set; }
        public string RegisteringEmployee { get; private set; }
        public int NoInWarehouse { get; private set; }
        public DateTime ShipmentDate { get; private set; }
        public string ShelfID { get; private set; } 

        public Product()
        {
            
        }
        public Product(string model)
        {
            this.Model = model;
        }

        public Product(string model, string brand)
        {
            this.Model = model;
            this.BrandName = brand;
        }

        public Product(string model, string brand, double price, int nrInWarehouse,int aisleNr, string shelfID)
        {
            this.Model = model;
            this.BrandName = brand;
            this.Price = price;
            this.NoInWarehouse = nrInWarehouse;
            this.AisleNumber = aisleNr;
            this.ShelfID = shelfID;
        }


        public Product(string model, string brand, double weight, double height, double width, string description, Department category, double price, int aisleNumber, int locationLeft, int locationRight, string registeringEmployee, int noInWarehouse, DateTime shipmentDate, string ShelfID)
        {
            this.Model = model;
            this.BrandName = brand;
            this.Weight = weight;
            this.Height = height;
            this.Width = width;
            this.Description = description;
            this.Category = category;
            this.Price = price;
            this.AisleNumber = aisleNumber;
            this.LocationLeft = locationLeft;
            this.LocationRight = locationRight;
            this.RegisteringEmployee = registeringEmployee;
            this.NoInWarehouse = noInWarehouse;
            this.ShipmentDate = shipmentDate;
            this.ShelfID = ShelfID;
        }



        public override string ToString()
        {
            return this.Model + ", " + this.BrandName;
        }
    }
}
