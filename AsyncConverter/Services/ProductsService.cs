using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AsyncConverter.Models;

namespace AsyncConverter.Services
{
    public class ProductsService
    {
        public ProductsService()
        {
        }

        public async Task<List<Product>> GetProducts()
        {
            await Task.Delay(300);
            List<Product> res = new List<Product>();
            // lets create some data, a real service would load it from database
            res.Add(Product.CreateMock("WiFi Speaker"));
            res.Add(Product.CreateMock("Cool Flat Screen TV"));
            res.Add(Product.CreateMock("Dishwasher"));
            res.Add(Product.CreateMock("DAB+ Radio"));
            res.Add(Product.CreateMock("Coffee mill"));
            res.Add(Product.CreateMock("Clock"));
            res.Add(Product.CreateMock("Tablet PC"));
            res.Add(Product.CreateMock("Sneaker"));
            return res;
        }
    }
}
