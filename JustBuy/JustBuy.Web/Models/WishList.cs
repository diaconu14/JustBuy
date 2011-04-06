using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JustBuy.Web.Models
{
    public class WishList
    {
        public IEnumerable<ProductModel> Products { get; set; }
    }
}
