using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLineItemApp.Model
{
    internal class Product
    {
        private int _id;
        private string _name;
        private double _unitPrice;
        private double _discountPercent;
        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public double UnitPrice { get { return _unitPrice; } set { _unitPrice = value; } }
        public double DiscountPercent { get { return _discountPercent; } set { _discountPercent = value; } }
        public Product(int id, string name, double unitPrice, double discountPercent)
        {
            Id = id;
            Name = name;
            UnitPrice = unitPrice;
            DiscountPercent = discountPercent;
        }
        public double CalculateDiscountedPrice()
            {
            double discountedPrice = UnitPrice - (UnitPrice * (DiscountPercent / 100));
            return discountedPrice;
        }
        public override string ToString()
        {
            return $"Product ID:{Id}Name:{Name},Unit Price:{UnitPrice},Discount Percent:{DiscountPercent}%,UnitCostAfterDiscount: {CalculateDiscountedPrice()}";
        }

    }
}

