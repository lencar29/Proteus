using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Iagency_people_roles
    {
        agency agency { get; set; }
        int agency_people_role_pk { get; set; }
        int? agency_pk { get; set; }
        int people_pk { get; set; }
        person person { get; set; }
        role role { get; set; }
        int role_pk { get; set; }
    }
}
