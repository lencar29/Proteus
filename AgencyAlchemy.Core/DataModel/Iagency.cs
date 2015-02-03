using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Iagency
    {
        string agency_address { get; set; }
        bool agency_approved { get; set; }
        string agency_city { get; set; }
        string agency_css { get; set; }
        byte agency_display_nameformat { get; set; }
        string agency_email { get; set; }
        string agency_footer { get; set; }
        string agency_googleanalytics { get; set; }
        bool agency_has_favicon { get; set; }
        bool agency_has_logo { get; set; }
        string agency_home_text { get; set; }
        string agency_home_title { get; set; }
        string agency_home_youtube { get; set; }
        string agency_join_email { get; set; }
        string agency_join_firstname { get; set; }
        string agency_join_lastname { get; set; }
        int agency_level { get; set; }
        decimal? agency_location_lat { get; set; }
        decimal? agency_location_long { get; set; }
        string agency_location_name { get; set; }
        string agency_location_url { get; set; }
        string agency_mail_welcomeapplicant { get; set; }
        System.Collections.Generic.ICollection<agency_metrics_categories> agency_metrics_categories { get; set; }
        string agency_name { get; set; }
        System.Collections.Generic.ICollection<agency_people> agency_people { get; set; }
        string agency_phone { get; set; }
        int agency_pk { get; set; }
        int? agency_skin_compsheet { get; set; }
        int? agency_skin_talent_private { get; set; }
        int? agency_skin_talent_public { get; set; }
        string agency_social_facebook { get; set; }
        string agency_social_gplus { get; set; }
        string agency_social_linkedin { get; set; }
        string agency_social_twitter { get; set; }
        string agency_social_youtube { get; set; }
        string agency_state { get; set; }
        string agency_talentapply_photo1 { get; set; }
        string agency_talentapply_photo2 { get; set; }
        string agency_talentapply_photo3 { get; set; }
        string agency_talentapply_photo4 { get; set; }
        string agency_talentapply_photo5 { get; set; }
        int agency_talentapply_photoreq { get; set; }
        string agency_taxid { get; set; }
        string agency_template_event { get; set; }
        string agency_template_slot_client { get; set; }
        string agency_template_slot_public { get; set; }
        string agency_template_slot_talent { get; set; }
        string agency_url { get; set; }
        string agency_zipcode { get; set; }
        System.Collections.Generic.ICollection<client_dispositions> client_dispositions { get; set; }
        System.Collections.Generic.ICollection<collection> collections { get; set; }
        DateTime? CreatedOn { get; set; }
        System.Collections.Generic.ICollection<domain> domains { get; set; }
        System.Collections.Generic.ICollection<@event> events { get; set; }
        System.Collections.Generic.ICollection<mailer> mailers { get; set; }
        System.Collections.Generic.ICollection<medium> media { get; set; }
        System.Collections.Generic.ICollection<page_settings> page_settings { get; set; }
        System.Collections.Generic.ICollection<page> pages { get; set; }
        System.Collections.Generic.ICollection<rate_types> rate_types { get; set; }
        byte[] RowVersion { get; set; }
        System.Collections.Generic.ICollection<testimonial> testimonials { get; set; }
    }
}
