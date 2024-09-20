using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Link_Query
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Categories = new Category[]
                {
                new Category {CategoryID=1, CatergoryName="Shirt" },
                new Category {CategoryID=2,CatergoryName="Pant" }
                };
            var Models = new ProductModel[]
              {
                new ProductModel {ProductModelId=1,ProductModelName="Mans Shirt" },
                new ProductModel {ProductModelId=2,ProductModelName="Mans Pant"},
                new ProductModel {ProductModelId=3,ProductModelName="Womans Shirt"},
                new ProductModel {ProductModelId=4,ProductModelName="Womans Pant"}
              };
            var Products = new Product[]
                {
                new Product {ProductId=1,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ProductModelId=1, CategoryID=1, Fixedprice=700, Quantity=4},
                new Product {ProductId=2,ProductName="Casual Pant",PruductNumber=1213,Color="Blue", ProductModelId=2, CategoryID=2, Fixedprice=800, Quantity=9},
                new Product {ProductId=3,ProductName="Formal Shirt",PruductNumber=1214,Color="Green", ProductModelId=1, CategoryID=1, Fixedprice=300, Quantity=4},
                new Product {ProductId=4,ProductName="Formal Pant",PruductNumber=1212,Color="Yellow", ProductModelId=2, CategoryID=2, Fixedprice=400, Quantity=4},
                new Product {ProductId=1,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ProductModelId=1, CategoryID=1, Fixedprice=700, Quantity=4},

                new Product {ProductId=5,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ProductModelId=3, CategoryID=1, Fixedprice=700, Quantity=4},
                new Product {ProductId=6,ProductName="Casual Pant",PruductNumber=1213,Color="Blue", ProductModelId=4, CategoryID=2, Fixedprice=800, Quantity=9},
                new Product {ProductId=7,ProductName="Formal Shirt",PruductNumber=1214,Color="Green", ProductModelId=3, CategoryID=1, Fixedprice=300, Quantity=4},
                new Product {ProductId=8,ProductName="Formal Pant",PruductNumber=1212,Color="Yellow", ProductModelId=4, CategoryID=2, Fixedprice=400, Quantity=4},
                new Product {ProductId=9,ProductName="Polo Shirt",PruductNumber=1212,Color="Red", ProductModelId=3, CategoryID=1, Fixedprice=700, Quantity=4},

                };
            Console.WriteLine("Joining Three Table");
            var global = from P in Products
                         join C in Categories
                         on P.CategoryID equals C.CategoryID
                         join M in Models
                         on P.ProductModelId equals M.ProductModelId
                         select new
                         {
                             Product = P.ProductId,
                             category = C.CatergoryName,
                             model = M.ProductModelName,
                             P.Color,
                             P.Fixedprice,
                             P.ProductName,
                         };
            foreach (var x in global)
            {
                Console.WriteLine($"{x.ProductName}\t{x.model}\t{x.Color}\t{x.Fixedprice}");
            }
            Console.ReadLine();

        }
    }
}
