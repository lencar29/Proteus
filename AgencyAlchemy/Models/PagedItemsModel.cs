using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AgencyAlchemy.Models
{
    public class PagedItemsModel
    {
        public int Page { get; set; }
        public int PageSize {get; set;}
        public  IEnumerable<dynamic> Items { get; set; }
        public  int TotalRows { get; set; }
        public int Pages
        {
            get { return Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRows / PageSize))); }
        }
    }
}