//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgencyAlchemy.Core.DataModel
{
    using System;
    
    public partial class skillstree_category_fetch_Result
    {
        public string type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public string fullname { get; set; }
        public Nullable<int> ordinal { get; set; }
        public Nullable<int> children_categories { get; set; }
        public Nullable<int> children_metrics { get; set; }
        public int selected { get; set; }
        public bool contains_cats { get; set; }
        public bool is_multiple { get; set; }
        public bool metriccategory_calculated { get; set; }
    }
}
