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
    
    public partial class event_slotdates
    {
        public int slotdate_pk { get; set; }
        public int slotdate_event_fk { get; set; }
        public int slotdate_slot_fk { get; set; }
        public System.DateTime slotdate_date { get; set; }
        public Nullable<System.TimeSpan> slotdate_start { get; set; }
        public Nullable<System.TimeSpan> slotdate_end { get; set; }
    
        public virtual event_slots event_slots { get; set; }
    }
}
