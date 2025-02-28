using ClassLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public IMoney Price { get; set; }

        public string Category { get; set; }

        public Product(string name, Money price, string category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public void DecreasePrice(int amount)
        {
            int totalCents = Price.WholePart * 100 + Price.Cents - amount;
            Price.WholePart = totalCents / 100;
            Price.Cents = totalCents % 100;
        }
    }
}
