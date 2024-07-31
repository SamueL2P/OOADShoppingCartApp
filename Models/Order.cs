using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADShoppingCartApp.Models
{
    internal class Order
    {
        static int orderno = 0;
        public int Id { get; set; } 

        public DateTime Date { get; set; }

        public List<LineItem> lineItems { get; set; } = new List<LineItem>();
        public Order(int id , DateTime date)
        {
            Id = id;
            Date = date;
            
        }

        public double CalculateOrderPrice()
        {
            double orderCost = 0;
            foreach (LineItem lineItem in lineItems) {
                orderCost += lineItem.CalculateLineItemCost();
            }
            return orderCost;
        }

        public override string ToString() {
            orderno++;
            return $"Order No : {orderno} \n" +
                $"Order Id : {Id}\n" +
                $"Order Date : {Date}\n";
        }
    }
}
