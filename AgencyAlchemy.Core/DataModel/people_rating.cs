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
    
    public partial class people_rating
    {
        public int peoplerating_pk { get; set; }
        public int peoplerating_target_people_fk { get; set; }
        public int peoplerating_source_people_fk { get; set; }
        public System.DateTime peoplerating_created { get; set; }
        public int peoplerating_score { get; set; }
        public int peoplerating_criteria_fk { get; set; }
        public string peoplerating_source_notes { get; set; }
        public Nullable<int> peoplerating_event_fk { get; set; }
    
        public virtual person person { get; set; }
        public virtual person person1 { get; set; }
    }
}
