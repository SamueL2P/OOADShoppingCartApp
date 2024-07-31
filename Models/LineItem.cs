using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOADShoppingCartApp.Models
{
    internal class LineItem
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public Product product { get; set; }



        public LineItem(int id , int quantity , Product prod)
        {
           Id = id ;
           Quantity = quantity ;
           product = prod ;

        }

        public double CalculateLineItemCost()
        {
            return (product.CalculateDiscountedPrice() * Quantity);
        }

        public override string ToString() {

            return $"Id   ProductId ProductName Quantity UnitPrice Discount% UnitCostAfterDiscount TotalLineItemCost \n{Id}   {product.Id}        {product.Name}       {Quantity}         {product.Price}      {product.DiscountPercent}         {product.CalculateDiscountedPrice()}                     {CalculateLineItemCost()}";
        }

        
    }
}
 