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
    
    public partial class page
    {
        public int page_pk { get; set; }
        public int page_agency_fk { get; set; }
        public string page_url { get; set; }
        public string page_nav_parent { get; set; }
        public Nullable<byte> page_nav_parent_ordinal { get; set; }
        public string page_nav_text { get; set; }
        public bool page_nav_display { get; set; }
        public byte page_nav_ordinal { get; set; }
        public System.DateTime page_created { get; set; }
    
        public virtual agency agency { get; set; }
    }
}
