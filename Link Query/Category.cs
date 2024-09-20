using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Link_Query
{
    public  class Category
    {
        public int CategoryID { get; set; }
        public string CatergoryName { get; set; }
        public ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public Category(int categoryid, string categoryname):this()
        {
            CategoryID = categoryid;
            CatergoryName = categoryname;
        }
    }
}
