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
    
    public partial class page_settings
    {
        public string pagesetting_meta_pagetitle { get; set; }
        public string pagesetting_meta_keywords { get; set; }
        public string pagesetting_meta_desc { get; set; }
        public string pagesetting_path { get; set; }
        public Nullable<int> pagesetting_agency_fk { get; set; }
        public string pagesetting_title { get; set; }
        public string pagesetting_subtitle { get; set; }
        public string pagesetting_desc { get; set; }
    
        public virtual agency agency { get; set; }
    }
}