using System;
using System.Collections.Generic;

namespace JustBuy.Web.Models
{
    public class BlogModel
    {
        private IList<BlogPost> blogPosts;
        public IList<BlogPost> BlogPosts
        {
            get
            {
                if (blogPosts == null)
                {
                    return new List<BlogPost> { new BlogPost { Content = "", Created = DateTime.Now, CreatedBy = "", Title = "" } };
                }
                return blogPosts;
            }
            set { blogPosts = value; }
        }

        public bool Enabled { get; set; }
        public bool AllowAnonimusComments { get; set; }
        public bool Notify { get; set; }
        public int PageSize { get; set; }
    }
}