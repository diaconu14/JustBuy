using System;
using System.Collections.Generic;

namespace JustBuy.Web.Models
{
    public class ProfileModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public AdressModel ShippingAdress { get; set; }
        public AdressModel ContactAdress { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public bool WhantNewsletters { get; set; }
        public string Company { get; set; }
        public AdressModel CompanyAdress { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string Role { get; set; }
        public string Comment { get; set; }
        public bool Active { get; set; }
        public DateTime RegistrationDate { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public WishList WishList { get; set; }
    }
}