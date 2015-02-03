using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Iclient
    {
        System.Collections.Generic.ICollection<agency_people> agency_people { get; set; }
        int client_agency_fk { get; set; }
        string client_billing_address1 { get; set; }
        string client_billing_address2 { get; set; }
        string client_billing_city { get; set; }
        string client_billing_state { get; set; }
        string client_billing_zip { get; set; }
        DateTime client_created { get; set; }
        int? client_disposition_fk { get; set; }
        int? client_gen_events { get; set; }
        double? client_gen_rating { get; set; }
        bool client_is_active { get; set; }
        double? client_lat { get; set; }
        string client_logo_path { get; set; }
        double? client_long { get; set; }
        int? client_manager_fk { get; set; }
        string client_name { get; set; }
        string client_notes { get; set; }
        int client_pk { get; set; }
        byte? client_status { get; set; }
        int? client_status_admin_fk { get; set; }
        DateTime? client_status_date { get; set; }
        string client_website { get; set; }
        System.Collections.Generic.ICollection<collection> collections { get; set; }
        System.Collections.Generic.ICollection<@event> events { get; set; }
        byte[] RowVersion { get; set; }
    }
}
