using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Imedium
    {
        agency agency { get; set; }
        int? media_agency_fk { get; set; }
        int media_agency_ordinal { get; set; }
        int? media_client_fk { get; set; }
        int media_client_ordinal { get; set; }
        DateTime media_created { get; set; }
        int media_creator { get; set; }
        int? media_event_fk { get; set; }
        int media_event_ordinal { get; set; }
        bool media_is_local { get; set; }
        string media_path { get; set; }
        int? media_people_fk { get; set; }
        int media_people_ordinal { get; set; }
        int media_pk { get; set; }
        int? media_slot_fk { get; set; }
        string media_thumb { get; set; }
        string media_title { get; set; }
        string media_type { get; set; }
        Guid media_unique { get; set; }
        bool media_visible_booked { get; set; }
        bool media_visible_client { get; set; }
        bool media_visible_unbooked { get; set; }
    }
}
