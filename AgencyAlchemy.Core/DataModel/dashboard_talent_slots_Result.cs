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
    
    public partial class dashboard_talent_slots_Result
    {
        public int event_pk { get; set; }
        public Nullable<System.DateTime> event_startdate { get; set; }
        public Nullable<System.DateTime> event_enddate { get; set; }
        public Nullable<int> manager_fk { get; set; }
        public int event_agency_fk { get; set; }
        public string event_title { get; set; }
        public string event_description { get; set; }
        public string event_summary { get; set; }
        public string event_website { get; set; }
        public string event_location_name { get; set; }
        public string event_location_address { get; set; }
        public string event_location_city { get; set; }
        public string event_location_state { get; set; }
        public string event_location_zip { get; set; }
        public Nullable<double> event_location_latitude { get; set; }
        public Nullable<double> event_location_longitude { get; set; }
        public string client_name { get; set; }
        public Nullable<int> event_client_fk { get; set; }
        public string eventstatus_name { get; set; }
        public byte event_status_fk { get; set; }
        public Nullable<int> event_category1_fk { get; set; }
        public Nullable<int> event_category2_fk { get; set; }
        public Nullable<int> event_category3_fk { get; set; }
        public System.Guid event_unique { get; set; }
        public Nullable<int> booked { get; set; }
        public int total { get; set; }
        public bool event_allow_freelancers { get; set; }
        public int eventpeople_pk { get; set; }
        public int eventpeople_people_fk { get; set; }
        public int eventpeople_event_fk { get; set; }
        public int eventpeople_slot_fk { get; set; }
        public bool eventpeople_is_owner { get; set; }
        public Nullable<System.DateTime> eventpeople_approved_client { get; set; }
        public Nullable<System.DateTime> eventpeople_approved_people { get; set; }
        public Nullable<System.DateTime> eventpeople_approved_agency { get; set; }
        public Nullable<System.DateTime> eventpeople_declined_client { get; set; }
        public Nullable<System.DateTime> eventpeople_declined_people { get; set; }
        public Nullable<System.DateTime> eventpeople_declined_agency { get; set; }
        public Nullable<int> eventpeople_clientpeople_fk { get; set; }
        public Nullable<int> eventpeople_agencypeople_fk { get; set; }
        public Nullable<byte> eventpeople_status { get; set; }
        public Nullable<int> eventpeople_review_client_fk { get; set; }
        public Nullable<byte> eventpeople_review_rating { get; set; }
        public string eventpeople_review_text { get; set; }
        public Nullable<System.DateTime> eventpeople_review_date { get; set; }
        public bool eventpeople_ignored { get; set; }
        public Nullable<int> eventpeople_ratetype_fk { get; set; }
        public Nullable<decimal> eventpeople_rate { get; set; }
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
    }
}
