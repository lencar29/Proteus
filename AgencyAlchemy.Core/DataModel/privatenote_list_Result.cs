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
    
    public partial class privatenote_list_Result
    {
        public int privatenotes_pk { get; set; }
        public string privatenotes_text { get; set; }
        public bool privatenotes_is_shared { get; set; }
        public int privatenotes_user_fk { get; set; }
        public string author { get; set; }
        public System.DateTime privatenotes_created { get; set; }
    }
}
