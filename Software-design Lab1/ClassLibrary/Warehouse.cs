using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowProducts()
        {
            foreach (var product in products)
            {
                Console.WriteLine($"{product.Name} - {product.Price.WholePart}.{product.Price.Cents:D2}");
            }
        }
    }
}
