using OrderLineItemApp.Model;
namespace OrderLineItemApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Product product = new Product(11, "Pen", 100, 10);
            Product product1 = new Product(12, "Pencil", 50, 20);
            Product product2 = new Product(13, "Book", 120, 5);
            Product product3 = new Product(14, "Bag", 800, 20);

            LineItem lineItem = new LineItem(100, 2, product);
            LineItem lineItem1 = new LineItem(101, 3, product1);

            Order order1 = new Order(111, DateTime.Now, new List<LineItem> { lineItem, lineItem1 });

            LineItem lineItem2 = new LineItem(102, 2, product2);
            LineItem lineItem3 = new LineItem(103, 1, product3);

            Order order2 = new Order(112, DateTime.Now, new List<LineItem> { lineItem2, lineItem3 });

            Customer customer = new Customer(1, "Adithya", new List<Order> { order1, order2 });

            Console.WriteLine("********************Welcome to Customer-Order App********************");
            Console.WriteLine($"Customer ID: {customer.Id}");
            Console.WriteLine($"Customer Name: {customer.Name}");
            Console.WriteLine($"Order Count: {customer.Orders.Count}");
            Console.WriteLine("==========================================");

            foreach (Order order in customer.Orders)
            {
                Console.WriteLine(order.ToString());
                foreach (LineItem LineItem in order.LineItems)
                {
                    Console.WriteLine(LineItem.ToString());


                }

                Console.WriteLine("================================");

            }
            Console.WriteLine($"Total Order Cost:" + customer.GetTotalOrderCost());


        }
    }
}


