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
    using System.Collections.Generic;
    
    public partial class v_people_metrics
    {
        public int Expr1 { get; set; }
        public int Expr2 { get; set; }
        public bool Expr3 { get; set; }
        public int peoplemetrics_people_fk { get; set; }
        public int peoplemetrics_metric_fk { get; set; }
        public System.DateTime peoplemetrics_created { get; set; }
        public bool peoplemetrics_is_featured { get; set; }
        public int peoplemetrics_pk { get; set; }
        public Nullable<int> peoplemetrics_agency_fk { get; set; }
        public int metric_pk { get; set; }
        public int metric_category_fk { get; set; }
        public string metric_title { get; set; }
        public System.DateTime metric_created { get; set; }
        public int metric_ordinal { get; set; }
        public Nullable<bool> metric_is_rated { get; set; }
        public string metric_lineage { get; set; }
        public int metriccategory_pk { get; set; }
        public int metriccategory_parent_fk { get; set; }
        public string metriccategory_title { get; set; }
        public bool metriccategory_is_multiple { get; set; }
        public bool metriccategory_is_eventcat { get; set; }
        public Nullable<int> metriccategory_ordinal { get; set; }
        public bool metriccategory_contains_categories { get; set; }
        public string metriccategory_lineage { get; set; }
        public bool metriccategory_calculated { get; set; }
        public string metriccategory_fulltitle { get; set; }
    }
}
