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
    
    public partial class metric
    {
        public metric()
        {
            this.event_slots = new HashSet<event_slots>();
        }
    
        public int metric_pk { get; set; }
        public int metric_category_fk { get; set; }
        public string metric_title { get; set; }
        public System.DateTime metric_created { get; set; }
        public int metric_ordinal { get; set; }
        public Nullable<bool> metric_is_rated { get; set; }
        public string metric_lineage { get; set; }
    
        public virtual metrics_categories metrics_categories { get; set; }
        public virtual ICollection<event_slots> event_slots { get; set; }
    }
}
