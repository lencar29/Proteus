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
    
    public partial class agency_metrics_categories
    {
        public int amc_category_fk { get; set; }
        public int amc_agency_fk { get; set; }
        public bool amc_is_quicksearch { get; set; }
        public bool amc_is_compsheet { get; set; }
        public System.DateTime amc_created { get; set; }
    
        public virtual agency agency { get; set; }
        public virtual metrics_categories metrics_categories { get; set; }
    }
}
