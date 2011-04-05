namespace JustBuy.Web.Models
{
    public class AdressModel
    {
        public string StreetAddress { get; set; }
        public int PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public AdressType Type { get; set; }
    }
}