using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Query
{
    public  class ProductModel
    {
        public int ProductModelId { get; set; }
        public string ProductModelName { get; set; }
        public ICollection<Product> Products { get; set; }
        public ProductModel()
        {
            Products = new HashSet<Product>();
        }
        public ProductModel(int productmodelid, string productmodelname) : this()
        {
            ProductModelId = productmodelid;
            ProductModelName = productmodelname;
        }

    }
}
