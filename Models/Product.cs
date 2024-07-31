using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADShoppingCartApp.Models
{
    internal class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public double DiscountPercent { get; set; }

        public Product(int id , string name , double price , double dp)
        {
            Id= id;
            Name= name;
            Price= price;
            DiscountPercent= dp;
        }

        public double CalculateDiscountedPrice()
        {   
            return Price * (1 - (DiscountPercent / 100));
        }
    }
}
