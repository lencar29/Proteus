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
    
    public partial class documents_list_client_Result
    {
        public int media_pk { get; set; }
        public string media_title { get; set; }
        public string media_path { get; set; }
        public string media_thumb { get; set; }
        public System.DateTime media_created { get; set; }
        public string media_type { get; set; }
        public int media_creator { get; set; }
        public Nullable<int> media_people_fk { get; set; }
        public int media_people_ordinal { get; set; }
        public Nullable<int> media_agency_fk { get; set; }
        public int media_agency_ordinal { get; set; }
        public Nullable<int> media_event_fk { get; set; }
        public int media_event_ordinal { get; set; }
        public Nullable<int> media_client_fk { get; set; }
        public int media_client_ordinal { get; set; }
        public bool media_is_local { get; set; }
        public System.Guid media_unique { get; set; }
        public Nullable<int> media_slot_fk { get; set; }
        public bool media_visible_unbooked { get; set; }
        public bool media_visible_booked { get; set; }
        public bool media_visible_client { get; set; }
        public Nullable<int> people_pk { get; set; }
        public string people_firstname { get; set; }
        public string people_lastname { get; set; }
        public string people_email { get; set; }
        public string people_address { get; set; }
        public string people_address2 { get; set; }
        public string people_city { get; set; }
        public string people_state { get; set; }
        public string people_postal { get; set; }
        public string people_phone { get; set; }
        public string people_cell { get; set; }
        public string people_home_phone { get; set; }
        public string people_skype { get; set; }
        public string people_fax { get; set; }
        public Nullable<System.DateTime> people_created { get; set; }
        public string people_auth_facebook { get; set; }
        public string people_auth_google { get; set; }
        public string people_auth_twitter { get; set; }
        public string people_auth_openid { get; set; }
        public string people_auth_aol { get; set; }
        public string people_social_gm { get; set; }
        public string people_social_mm { get; set; }
        public string people_social_omp { get; set; }
        public Nullable<System.Guid> people_unique { get; set; }
        public Nullable<bool> people_preserve { get; set; }
        public Nullable<System.DateTime> people_birthdate { get; set; }
        public string people_formalname { get; set; }
        public Nullable<byte> people_joinstep { get; set; }
        public byte[] people_password { get; set; }
        public Nullable<System.Guid> people_password_salt { get; set; }
        public Nullable<System.Guid> people_cookie { get; set; }
        public Nullable<int> people_manager_fk { get; set; }
        public Nullable<System.DateTime> people_last_on { get; set; }
        public string people_facebook_link { get; set; }
        public string people_instagram_link { get; set; }
        public string people_googleplus_link { get; set; }
        public string people_twitter_link { get; set; }
        public string people_linkedin_link { get; set; }
        public string people_guardian { get; set; }
        public string people_guardianphone { get; set; }
        public Nullable<int> agencypeople_pk { get; set; }
        public Nullable<int> agencypeople_agency_fk { get; set; }
        public Nullable<int> agencypeople_people_fk { get; set; }
        public Nullable<int> agencypeople_client_fk { get; set; }
        public Nullable<System.Guid> agencypeople_unique { get; set; }
        public string agencypeople_stagename { get; set; }
        public string agencypeople_displayname { get; set; }
        public string agencypeople_notes { get; set; }
        public string agencypeople_title { get; set; }
        public string agencypeople_biography { get; set; }
        public string agencypeople_experience { get; set; }
        public Nullable<int> agencypeople_todo_bitmask { get; set; }
        public Nullable<bool> agencypeople_is_exclusive { get; set; }
        public Nullable<int> is_talent { get; set; }
        public Nullable<int> talent_is_featured { get; set; }
        public Nullable<int> is_agencyadmin { get; set; }
        public Nullable<int> is_clientadmin { get; set; }
        public Nullable<int> is_superadmin { get; set; }
        public Nullable<int> is_active { get; set; }
        public Nullable<int> agency_is_active { get; set; }
        public Nullable<int> talent_is_displayed { get; set; }
        public Nullable<int> is_talentmanager { get; set; }
        public Nullable<int> is_clientmanager { get; set; }
        public Nullable<int> is_applicant { get; set; }
        public string cookie { get; set; }
        public string people_location_name { get; set; }
        public string people_location_url { get; set; }
        public Nullable<decimal> people_location_lat { get; set; }
        public Nullable<decimal> people_location_long { get; set; }
        public Nullable<int> client_pk { get; set; }
        public Nullable<int> client_agency_fk { get; set; }
        public string client_logo_path { get; set; }
        public string client_name { get; set; }
        public Nullable<System.DateTime> client_created { get; set; }
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
        public Nullable<bool> client_is_active { get; set; }
        public Nullable<int> client_disposition_fk { get; set; }
        public string client_website { get; set; }
        public Nullable<int> client_manager_fk { get; set; }
        public Nullable<int> eventslots_pk { get; set; }
        public Nullable<int> eventslots_event_fk { get; set; }
        public Nullable<byte> eventslots_status_fk { get; set; }
        public Nullable<bool> eventslots_status_forced { get; set; }
        public Nullable<System.DateTime> eventslots_approved { get; set; }
        public Nullable<byte> eventslots_quantity { get; set; }
        public string eventslots_name { get; set; }
        public string eventslots_description { get; set; }
        public string eventslots_description_client { get; set; }
        public string eventslots_description_talent { get; set; }
        public Nullable<int> eventslots_metric_fk { get; set; }
        public Nullable<int> eventslots_category1_fk { get; set; }
        public Nullable<int> eventslots_category2_fk { get; set; }
        public Nullable<int> eventslots_category3_fk { get; set; }
        public Nullable<System.Guid> eventslots_unique { get; set; }
        public string eventslots_location_name { get; set; }
        public string eventslots_location_url { get; set; }
        public Nullable<decimal> eventslots_location_lat { get; set; }
        public Nullable<decimal> eventslots_location_long { get; set; }
        public Nullable<bool> eventslots_allow_freelancers { get; set; }
        public string uniqueid { get; set; }
    }
}
