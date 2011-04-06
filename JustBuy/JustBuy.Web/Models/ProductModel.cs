using System;
using System.Collections.Generic;
using System.Drawing;

namespace JustBuy.Web.Models
{
    public class ProductModel
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string Comment { get; set; }
        public bool ShowOnHomePage { get; set; }
        public bool Published { get; set; }
        public bool AllowReviews { get; set; }
        public bool AllowRatings { get; set; }
        public string Tags { get; set; }
        public string ManId { get; set; }
        public Guid ProductId { get; set; }
        public double Price { get; set; }
        public double OldPrice { get; set; }
        public double ActualPrice { get; set; }
        public bool AllowBuy { get; set; }
        public DateTime AvailableStarDate { get; set; }
        public DateTime AvailableEndDate { get; set; }
        public bool IsDownloadable { get; set; }
        public bool ShippingEnabled { get; set; }
        public bool TaxExempt { get; set; }
        public string TaxCategory { get; set; }
        public int StockQuantity { get; set; }
        public bool DisplayStockAvailability { get; set; }
        public int NotifyAdminFor { get; set; }
        public int MaximumCartQuantity { get; set; }
        public string MetaKey { get; set; }
        public string MetaValue { get; set; }
        public string Category { get; set; }
        public Image Picture { get; set; }
        public IDictionary<string, string> Properties { get; set; }
    }
}