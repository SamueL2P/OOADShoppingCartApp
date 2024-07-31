using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADShoppingCartApp.Models
{
    internal class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Order> orders { get; set; } = new List<Order>();

        public Customer(int id , string name)
        {
            Id = id;    
            Name = name;
        }


        public override string ToString()
        {
            return $"Customer ID : {Id} \n" +
                $"Customer Name : {Name}\n" +
                $"Order Count : {orders.Count}\n";
        }
    }
}
