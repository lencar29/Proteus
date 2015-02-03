using System;
namespace AgencyAlchemy.Core.DataModel
{
    interface Iperson
    {
        System.Collections.Generic.ICollection<agency_people> agency_people { get; set; }
        System.Collections.Generic.ICollection<collectiontalent> collectiontalents { get; set; }
        System.Collections.Generic.ICollection<contract> contracts { get; set; }
        System.Collections.Generic.ICollection<event_people> event_people { get; set; }
        System.Collections.Generic.ICollection<metrics_custom> metrics_custom { get; set; }
        System.Collections.Generic.ICollection<note> notes { get; set; }
        string people_address { get; set; }
        string people_address2 { get; set; }
        string people_auth_aol { get; set; }
        string people_auth_facebook { get; set; }
        string people_auth_google { get; set; }
        string people_auth_openid { get; set; }
        string people_auth_twitter { get; set; }
        DateTime? people_birthdate { get; set; }
        string people_cell { get; set; }
        string people_city { get; set; }
        Guid? people_cookie { get; set; }
        DateTime people_created { get; set; }
        string people_email { get; set; }
        string people_facebook_link { get; set; }
        string people_fax { get; set; }
        string people_firstname { get; set; }
        string people_formalname { get; set; }
        string people_googleplus_link { get; set; }
        string people_guardian { get; set; }
        string people_guardianphone { get; set; }
        string people_home_phone { get; set; }
        string people_instagram_link { get; set; }
        byte people_joinstep { get; set; }
        DateTime? people_last_on { get; set; }
        string people_lastname { get; set; }
        string people_linkedin_link { get; set; }
        decimal? people_location_lat { get; set; }
        decimal? people_location_long { get; set; }
        string people_location_name { get; set; }
        string people_location_url { get; set; }
        System.Collections.Generic.ICollection<people_locations> people_locations { get; set; }
        int? people_manager_fk { get; set; }
        System.Collections.Generic.ICollection<people_metrics> people_metrics { get; set; }
        byte[] people_password { get; set; }
        Guid people_password_salt { get; set; }
        string people_phone { get; set; }
        int people_pk { get; set; }
        string people_postal { get; set; }
        bool people_preserve { get; set; }
        System.Collections.Generic.ICollection<people_rating> people_rating { get; set; }
        System.Collections.Generic.ICollection<people_rating> people_rating1 { get; set; }
        string people_skype { get; set; }
        string people_social_gm { get; set; }
        string people_social_mm { get; set; }
        string people_social_omp { get; set; }
        string people_state { get; set; }
        string people_twitter_link { get; set; }
        Guid people_unique { get; set; }
        System.Collections.Generic.ICollection<private_notes> private_notes { get; set; }
        System.Collections.Generic.ICollection<testimonial> testimonials { get; set; }
    }
}
