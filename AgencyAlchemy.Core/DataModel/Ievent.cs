using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Ievent
    {
        agency agency { get; set; }
        client client { get; set; }
        System.Collections.Generic.ICollection<contract> contracts { get; set; }
        int event_agency_fk { get; set; }
        bool event_allow_freelancers { get; set; }
        DateTime? event_approved { get; set; }
        int? event_approvedby_fk { get; set; }
        DateTime? event_archived { get; set; }
        int? event_archivedby_fk { get; set; }
        int? event_category1_fk { get; set; }
        int? event_category2_fk { get; set; }
        int? event_category3_fk { get; set; }
        int? event_client_fk { get; set; }
        System.Collections.Generic.ICollection<event_dates> event_dates { get; set; }
        string event_datetime_extrainfo { get; set; }
        string event_description { get; set; }
        DateTime? event_enddate { get; set; }
        string event_location_address { get; set; }
        string event_location_city { get; set; }
        double? event_location_latitude { get; set; }
        double? event_location_longitude { get; set; }
        string event_location_name { get; set; }
        string event_location_state { get; set; }
        string event_location_zip { get; set; }
        System.Collections.Generic.ICollection<event_people> event_people { get; set; }
        int event_pk { get; set; }
        System.Collections.Generic.ICollection<event_slots> event_slots { get; set; }
        DateTime? event_startdate { get; set; }
        byte event_status_fk { get; set; }
        bool event_status_forced { get; set; }
        event_statuses event_statuses { get; set; }
        string event_summary { get; set; }
        string event_title { get; set; }
        Guid event_unique { get; set; }
        string event_website { get; set; }
    }
}
