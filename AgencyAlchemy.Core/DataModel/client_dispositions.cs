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
    
    public partial class client_dispositions
    {
        public int disposition_pk { get; set; }
        public string disposition_name { get; set; }
        public int disposition_agency_fk { get; set; }
    
        public virtual agency agency { get; set; }
    }
}
