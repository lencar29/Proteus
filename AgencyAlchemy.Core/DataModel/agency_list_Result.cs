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
    
    public partial class agency_list_Result
    {
        public string agency_name { get; set; }
        public string agency_url { get; set; }
        public int agency_level { get; set; }
        public string agency_taxid { get; set; }
        public bool agency_approved { get; set; }
        public Nullable<int> talent_count { get; set; }
        public Nullable<int> event_count { get; set; }
        public Nullable<int> client_count { get; set; }
    }
}
