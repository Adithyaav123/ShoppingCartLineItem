using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineItemApp.Model
{
    internal class Order
    {

        private int id;
        private DateTime date;
        private List<LineItem> items;
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<LineItem> LineItems { get; set; }
       
        public Order(int id, DateTime date, List<LineItem> items)
        {
            Id = id;
            Date = date;
            LineItems = items;

           
        }
       
        public double CalculateOrderPrice()
        {
            double orderCost = 0;
            foreach (LineItem item in LineItems)
            {
                orderCost += item.CalculateLineItemCost();
               
            }
            return orderCost;
        }
        public override string ToString()
        {
            return $"Order ID: {Id}\nDate: {Date}\n\nOrder Cost: {CalculateOrderPrice()}\n";
        }


    }

}