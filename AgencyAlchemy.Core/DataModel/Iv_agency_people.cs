using System;
namespace AgencyAlchemy.Core.DataModel
{
    interface Iv_agency_people
    {
        int agency_is_active { get; set; }
        int? agencypeople_agency_fk { get; set; }
        string agencypeople_biography { get; set; }
        int? agencypeople_client_fk { get; set; }
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
        string cookie { get; set; }
        int is_active { get; set; }
        int is_agencyadmin { get; set; }
        int is_applicant { get; set; }
        int is_clientadmin { get; set; }
        int is_clientmanager { get; set; }
        int is_superadmin { get; set; }
        int is_talent { get; set; }
        int is_talentmanager { get; set; }
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
        int? people_manager_fk { get; set; }
        byte[] people_password { get; set; }
        Guid people_password_salt { get; set; }
        string people_phone { get; set; }
        int people_pk { get; set; }
        string people_postal { get; set; }
        bool people_preserve { get; set; }
        string people_skype { get; set; }
        string people_social_gm { get; set; }
        string people_social_mm { get; set; }
        string people_social_omp { get; set; }
        string people_state { get; set; }
        string people_twitter_link { get; set; }
        Guid people_unique { get; set; }
        int talent_is_displayed { get; set; }
        int talent_is_featured { get; set; }
    }
}
