using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Iagency_people
    {
        agency agency { get; set; }
        System.Collections.Generic.ICollection<agency_people_rates> agency_people_rates { get; set; }
        int? agencypeople_agency_fk { get; set; }
        int? agencypeople_applicant_eventslot_fk { get; set; }
        string agencypeople_biography { get; set; }
        int? agencypeople_client_fk { get; set; }
        DateTime? agencypeople_created { get; set; }
        string agencypeople_displayname { get; set; }
        string agencypeople_experience { get; set; }
        bool agencypeople_is_exclusive { get; set; }
        string agencypeople_notes { get; set; }
        int agencypeople_people_fk { get; set; }
        int agencypeople_pk { get; set; }
        string agencypeople_stagename { get; set; }
        string agencypeople_title { get; set; }
        int? agencypeople_todo_bitmask { get; set; }
        Guid agencypeople_unique { get; set; }
        client client { get; set; }
        System.Collections.Generic.ICollection<flag> flags { get; set; }
        person person { get; set; }
    }
}
