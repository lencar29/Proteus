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
    
    public partial class book_slot_fetch_Result
    {
        public int eventslots_pk { get; set; }
        public int eventslots_event_fk { get; set; }
        public byte eventslots_status_fk { get; set; }
        public bool eventslots_status_forced { get; set; }
        public Nullable<System.DateTime> eventslots_approved { get; set; }
        public byte eventslots_quantity { get; set; }
        public string eventslots_name { get; set; }
        public string eventslots_description { get; set; }
        public string eventslots_description_client { get; set; }
        public string eventslots_description_talent { get; set; }
        public Nullable<int> eventslots_metric_fk { get; set; }
        public Nullable<int> eventslots_category1_fk { get; set; }
        public Nullable<int> eventslots_category2_fk { get; set; }
        public Nullable<int> eventslots_category3_fk { get; set; }
        public System.Guid eventslots_unique { get; set; }
        public string eventslots_location_name { get; set; }
        public string eventslots_location_url { get; set; }
        public Nullable<decimal> eventslots_location_lat { get; set; }
        public Nullable<decimal> eventslots_location_long { get; set; }
        public bool eventslots_allow_freelancers { get; set; }
        public Nullable<int> positionstatus_pk { get; set; }
        public string positionstatus_name { get; set; }
        public string uniqueid { get; set; }
        public Nullable<int> unbooked { get; set; }
        public string category1 { get; set; }
        public string category2 { get; set; }
        public string category3 { get; set; }
    }
}
