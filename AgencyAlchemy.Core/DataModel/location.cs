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
    
    public partial class location
    {
        public int location_pk { get; set; }
        public double location_latitude { get; set; }
        public double location_longitude { get; set; }
        public string location_name { get; set; }
        public Nullable<int> location_agency_fk { get; set; }
        public Nullable<int> location_event_fk { get; set; }
        public Nullable<int> location_talent_fk { get; set; }
        public Nullable<int> location_client_fk { get; set; }
        public Nullable<System.DateTime> location_date_start { get; set; }
        public Nullable<System.DateTime> location_date_end { get; set; }
    }
}
