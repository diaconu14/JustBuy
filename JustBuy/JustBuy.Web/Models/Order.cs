using System;
using System.Collections.Generic;

namespace JustBuy.Web.Models
{
    public class Order
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string PaymentStatus { get; set; }
        public string ShippingStatus { get; set; }
        public double Total { get; set; }
        public Guid Id { get; set; }
        public string Customer { get; set; }
        public string CustomerIp  { get; set; }
        public double ShippingCost { get; set; }
        public string PaymentMethod { get; set; }
        public AdressModel BillingAdress { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public IEnumerable<ProductModel> Products { get; set; }
        public IEnumerable<string> Notes { get; set; }
    }
}