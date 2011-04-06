using System;

namespace JustBuy.Web.Models
{
    public class BlogPost
    {
        private string title;
        public string Title
        {
            get
            {
                if (title==null)
                {
                    return "";
                }
                return title;
            }
            set { title = value; }
        }

        private DateTime created;
        public DateTime Created
        {
            get
            {
                return created;
            }
            set { created = value; }
        }

        private string content;
        public string Content
        {
            get
            {
                if (content == null)
                {
                    return "";
                }
                
                return content;
            }
            set { content = value; }
        }

        private string createdBy;

        /// <summary>
        /// username
        /// </summary>
        public string CreatedBy
        {
            get
            {
                if (createdBy == null)
                {
                    return "NAN";
                }
                return createdBy;
            }
            set { createdBy = value; }
        }

        public string Language { get; set; }
        public bool AllowComments { get; set; }
        public string Tags { get; set; }
        public string Comments { get; set; }
    }
}
