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
    
    public partial class account_fetch_Result
    {
        public int people_pk { get; set; }
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
        public System.DateTime people_created { get; set; }
        public string people_auth_facebook { get; set; }
        public string people_auth_google { get; set; }
        public string people_auth_twitter { get; set; }
        public string people_auth_openid { get; set; }
        public string people_auth_aol { get; set; }
        public string people_social_gm { get; set; }
        public string people_social_mm { get; set; }
        public string people_social_omp { get; set; }
        public System.Guid people_unique { get; set; }
        public bool people_preserve { get; set; }
        public Nullable<System.DateTime> people_birthdate { get; set; }
        public string people_formalname { get; set; }
        public byte people_joinstep { get; set; }
        public byte[] people_password { get; set; }
        public System.Guid people_password_salt { get; set; }
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
        public string people_location_name { get; set; }
        public string people_location_url { get; set; }
        public Nullable<decimal> people_location_lat { get; set; }
        public Nullable<decimal> people_location_long { get; set; }
    }
}
