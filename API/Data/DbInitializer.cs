using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.Data
{
    public static class DbInitializer
    {
        public static void Initiliaze(StoreContext context)
        {
            if (context.Products.Any()) return;
            var products = new List<Product>
            {
                new Product
                {
                Name = "IPad",
                Description = "Ipad Air 2",
                Price = 560,
                Type = "Tablet",
                Brand = "Apple",
                PictureUrl = "https://www.pinterest.com",
                QuantityInStock = 5
                },
                 new Product
                {
                Name = "IPhone",
                Description = "Iphone 13 pro",
                Price = 900,
                Type = "Phone",
                Brand = "Apple",
                PictureUrl = "https://www.pinterest.com/",
                QuantityInStock = 15
                },
                 new Product
                {
                Name = "FitBit",
                Description = "Smart watch",
                Price = 500,
                Type = "Watch",
                Brand = "FitBit",
                PictureUrl = "https://www.pinterest.com",
                QuantityInStock = 50
                },
                 new Product
                {
                Name = "HP Spectre 360",
                Description = "HP Laptop",
                Price = 1560,
                Type = "Tablet",
                Brand = "Apple",
                PictureUrl = "https://www.pinterest.com",
                QuantityInStock = 5
                },
                 new Product
                {
                Name = "Samsung Flip",
                Description = "Samsung flip phone",
                Price = 600,
                Type = "Phone",
                Brand = "Samsung",
                PictureUrl = "https://www.pinterest.com/",
                QuantityInStock = 25
                }

            };

            foreach (var prod in products)
            {
                context.Products.Add(prod);
            }
            context.SaveChanges();
        }

    }
}