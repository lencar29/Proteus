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
    
    public partial class clients_add_Result
    {
        public int client_pk { get; set; }
        public int client_agency_fk { get; set; }
        public string client_logo_path { get; set; }
        public string client_name { get; set; }
        public System.DateTime client_created { get; set; }
        public Nullable<double> client_gen_rating { get; set; }
        public string client_billing_address1 { get; set; }
        public string client_billing_address2 { get; set; }
        public string client_billing_city { get; set; }
        public string client_billing_zip { get; set; }
        public string client_billing_state { get; set; }
        public Nullable<double> client_lat { get; set; }
        public Nullable<double> client_long { get; set; }
        public string client_notes { get; set; }
        public Nullable<int> client_gen_events { get; set; }
        public Nullable<byte> client_status { get; set; }
        public Nullable<System.DateTime> client_status_date { get; set; }
        public Nullable<int> client_status_admin_fk { get; set; }
        public bool client_is_active { get; set; }
        public Nullable<int> client_disposition_fk { get; set; }
        public string client_website { get; set; }
        public Nullable<int> client_manager_fk { get; set; }
    }
}
