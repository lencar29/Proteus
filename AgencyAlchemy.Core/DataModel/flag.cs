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
    
    public partial class flag
    {
        public flag()
        {
            this.agency_people = new HashSet<agency_people>();
        }
    
        public int flag_pk { get; set; }
        public string flag_layer { get; set; }
        public string flag_category { get; set; }
        public string flag_name { get; set; }
        public bool flag_default_authenticated { get; set; }
        public bool flag_default_talent { get; set; }
        public bool flag_default_client { get; set; }
        public bool flag_default_agencyadmin { get; set; }
        public bool flag_is_editable { get; set; }
    
        public virtual ICollection<agency_people> agency_people { get; set; }
    }
}
