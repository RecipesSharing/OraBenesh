using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace server.Models
{
    public class Category
    {
        public string categoryCode { get; set; }
        public string categoryName { get; set; }
        public string categoryPath { get; set; }

        public Category(string categoryCode, string categoryName, string categoryPath)
        {
            this.categoryCode = categoryCode;
            this.categoryName = categoryName;
            this.categoryPath = categoryPath;
        }
        public Category()
        {

        }
    }
}