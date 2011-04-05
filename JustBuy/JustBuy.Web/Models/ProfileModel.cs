using System;
using System.Collections.Generic;

namespace JustBuy.Web.Models
{
    public class ProfileModel
    {
        public string Email{ get; set; }
        public bool Gender { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IEnumerable<AdressModel> ShippingAdress { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public bool WhantNewsletters { get; set; }

    }
}