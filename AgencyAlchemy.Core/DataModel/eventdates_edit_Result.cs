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
    
    public partial class eventdates_edit_Result
    {
        public long eventdate_pk { get; set; }
        public string eventdate_description { get; set; }
        public int eventdate_event_fk { get; set; }
        public Nullable<int> eventdate_slot_fk { get; set; }
        public System.DateTime eventdate_start { get; set; }
        public Nullable<System.DateTime> eventdate_end { get; set; }
        public bool eventdate_is_allday { get; set; }
    }
}
