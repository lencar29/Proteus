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
    
    public partial class book_setstatus_Result
    {
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
    }
}
