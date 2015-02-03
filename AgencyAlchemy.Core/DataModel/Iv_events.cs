using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Iv_event
    {
        int? booked { get; set; }
        string client_name { get; set; }
        int event_agency_fk { get; set; }
        bool event_allow_freelancers { get; set; }
        int? event_category1_fk { get; set; }
        int? event_category2_fk { get; set; }
        int? event_category3_fk { get; set; }
        int? event_client_fk { get; set; }
        string event_description { get; set; }
        DateTime? event_enddate { get; set; }
        string event_location_address { get; set; }
        string event_location_city { get; set; }
        double? event_location_latitude { get; set; }
        double? event_location_longitude { get; set; }
        string event_location_name { get; set; }
        string event_location_state { get; set; }
        string event_location_zip { get; set; }
        int event_pk { get; set; }
        DateTime? event_startdate { get; set; }
        byte event_status_fk { get; set; }
        string event_summary { get; set; }
        string event_title { get; set; }
        Guid event_unique { get; set; }
        string event_website { get; set; }
        string eventstatus_name { get; set; }
        int? manager_fk { get; set; }
        int total { get; set; }
    }
}
