using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication;

namespace ProductService.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public int Price { get; set; }
    }


    public class ProductsDb:List<Product>
    {
        public ProductsDb()
        {
            Add(new Product() { ProductId = 1, ProductName = "Laptop", CategoryName = "Electronics", Price = 2300000 });
            Add(new Product() { ProductId = 2, ProductName = "Desktop", CategoryName = "Electronics", Price = 1300000 });
            Add(new Product() { ProductId = 3, ProductName = "Iron", CategoryName = "Electrical", Price = 2300 });
            Add(new Product() { ProductId = 4, ProductName = "Mixer", CategoryName = "Electrical", Price = 3000 });
            Add(new Product() { ProductId = 5, ProductName = "Biscuts", CategoryName = "Food", Price = 30 });
            Add(new Product() { ProductId = 6, ProductName = "Chips", CategoryName = "Food", Price = 20 });

        }

    }
}
