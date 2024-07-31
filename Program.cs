using OOADShoppingCartApp.Models;

namespace OOADShoppingCartApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(101, "Samuel");
            Order o1 = new Order(11 , DateTime.Now);
            Order o2 = new Order(12 , DateTime.Now);

            Product p1 = new Product(111, "mouse", 500, 10);
            Product p2 = new Product(112, "mouse", 500, 10);

            LineItem l1 = new LineItem(1111, 2, p1);
            LineItem l2 = new LineItem(1112, 3, p2);
            LineItem l3 = new LineItem(1113, 3, p1);
            LineItem l4 = new LineItem(1114, 1, p2);
            
            customer.orders.Add(o1);
            customer.orders.Add(o2);


            o1.lineItems.Add(l1);
            o1.lineItems.Add(l2);
            o2.lineItems.Add(l3);
            o2.lineItems.Add(l4);

            PrintDetails(customer);

        }

        static void PrintDetails(Customer customer)
        {
            Console.WriteLine(customer);

            foreach(Order order in customer.orders) {
                Console.WriteLine(order);
                foreach(LineItem lineItem in order.lineItems) 

                { Console.WriteLine(lineItem + "\n");
                   
                }
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t   ------");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t    " + order.CalculateOrderPrice());
            }
        }

    }
}
