using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Query
{
    public  class Product
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int PruductNumber { get; set; }
        public string Color { get; set; }
        public double Fixedprice { get; set; }
        public int CategoryID { get; set; }    // Foreign key reference to Category (Category ID to which the product belongs)

        public int ProductModelId { get; set; }
        public virtual Category category { get; set; }
        public virtual ProductModel model { get; set; }
        public Product()
        { }
        public Product(int productid, int quantity, string productname, int productnumber, string color, double price, int categoryid, int modelid) : this()
        { ProductId = productid;
            Quantity = quantity;
            ProductName = productname;
            PruductNumber = productnumber;
            Color = color;
            Fixedprice = price;
            CategoryID = categoryid;
            ProductModelId = modelid;
        }
    }
}
