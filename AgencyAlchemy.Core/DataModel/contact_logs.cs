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
    
    public partial class contact_logs
    {
        public int contactlog_agency_fk { get; set; }
        public int contactlog_people_fk { get; set; }
        public System.DateTime contactlog_datetime { get; set; }
        public string contactlog_text { get; set; }
        public int contactlog_type { get; set; }
        public int contactlog_pk { get; set; }
        public Nullable<int> contactlog_target_talent_fk { get; set; }
        public Nullable<int> contactlog_target_client_fk { get; set; }
        public bool contactlog_is_private { get; set; }
        public Nullable<int> contactlog_target_contact_fk { get; set; }
    }
}
