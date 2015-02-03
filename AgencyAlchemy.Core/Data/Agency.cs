using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class Agency:PersistentObject, Iagency, IPersistable
    {
        private Agency() : base() { }

        private Agency(agency agencyData)
            : base()
        {
            MapProperties(this, agencyData);
        }

        public Agency GetNew()
        {
            return new Agency();
        }

        public Agency FetchByAgencyId(int agencyId)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            Agency agncy = null;

            try
            {
                var agencyData = serviceProvider.agencies.Where(a => a.agency_pk == agencyId).Single();

                agncy = new Agency(agencyData);
            }
            catch (InvalidOperationException ioe) { }

            return agncy;
        }

        public static Agency GetAgencyByDomain(String domain)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            Agency agncy = null;

            try
            {
                var agencyData = (
                                     from a in serviceProvider.agencies
                                     join d in serviceProvider.domains
                                     on a.agency_pk equals d.domain_agency_fk
                                     where d.domain_url == domain
                                     select a
                                 ).Single();

                agncy = new Agency(agencyData);
            }
            
            catch (InvalidOperationException ioe) { }

            return agncy;

        }

        public static Agency GetAgencyBySubDomainName(String name)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            Agency agncy = null;

            try
            {
                var agencyData = (
                                     from a in serviceProvider.agencies                                   
                                     where a.agency_url == name
                                     select a
                                 ).Single();

                agncy = new Agency(agencyData);
            }

            catch (InvalidOperationException ioe) { }

            return agncy;

        }

        public static int GetAgencyIdBySubDomainName(String name)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            int agencyId = 0;

            try
            {
                agencyId = (
                                     from a in serviceProvider.agencies
                                     where a.agency_url == name
                                     select a.agency_pk
                                 ).Single();

            }

            catch (InvalidOperationException ioe) { }

            return agencyId;

        }

        public static IEnumerable<Agency> GetAllAgencies(out int count, int page = 1, int pageSize = 10)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            List<Agency> agencyList = new List<Agency>();
            int offset = (page - 1) * pageSize;
            count = 0;

            try
            {
                count = serviceProvider.agencies.Count();
                var agencies = serviceProvider.agencies.OrderBy(a => a.agency_name)
                                                            .Skip(offset)
                                                            .Take(pageSize)
                                                            .ToArray();
                                
                foreach (var agncy in agencies)                
                    agencyList.Add(new Agency(agncy));
                
            }
            catch (InvalidOperationException ioe) { }

            return agencyList.AsEnumerable();
        }

        public static List<agency_list_Result> GetAgencyMasterList(out int count, int page = 1, int pageSize = 10)
        {
            List<agency_list_Result> result = null;
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            int offset = (page - 1) * pageSize;
            count = 0;

            try
            {
                SqlParameter[] params1 = { new SqlParameter{ ParameterName="@Parameter1", Value="AML" } };
                SqlParameter[] params2 = { new SqlParameter { ParameterName = "@Parameter1", Value = "AML" } };
                count = serviceProvider.Database.SqlQuery<agency_list_Result>("exec agency_list", params1).Count();
                result= serviceProvider.Database.SqlQuery<agency_list_Result>("exec agency_list", params2)
                                                                                            .OrderBy(r => r.agency_name)
                                                                                            .Skip(offset)
                                                                                            .Take(pageSize)
                                                                                            .ToList();
            }
            catch (Exception e) { throw; }

            return result;
        }

        public static List<people_list_Result> GetUsersFromAllAgencies(out int count, int page = 1, int pageSize = 10)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            List<people_list_Result> result = null;
            int offset = (page - 1) * pageSize;
            count = 0;

            try
            {
                SqlParameter[] params1 = { new SqlParameter { ParameterName = "@Parameter1", Value = "AML" } };
                SqlParameter[] params2 = { new SqlParameter { ParameterName = "@Parameter1", Value = "AML" } };
                count = serviceProvider.Database.SqlQuery<people_list_Result>("Exec people_list", params1).Count();
                result = serviceProvider.Database.SqlQuery<people_list_Result>("Exec people_list", params2)
                                                                                            .OrderBy(a => a.agency_name)
                                                                                            .Skip(offset)
                                                                                            .Take(pageSize)
                                                                                            .ToList();
            }
            catch (InvalidOperationException ioe) { }

            return result;
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = {
                                               "agency_address","agency_approved","agency_city","agency_css","agency_display_nameformat","agency_email","agency_footer","agency_googleanalytics",
                                               "agency_has_favicon","agency_has_logo","agency_home_text","agency_home_title","agency_home_youtube","agency_join_email","agency_join_firstname",
                                               "agency_join_lastname","agency_level","agency_location_lat","agency_location_long","agency_location_name","agency_location_url","agency_mail_welcomeapplicant",
                                               "agency_name","agency_phone","agency_pk","agency_skin_compsheet","agency_skin_talent_private","agency_skin_talent_public","agency_social_facebook","agency_social_gplus",
                                               "agency_social_linkedin","agency_social_twitter","agency_social_youtube","agency_state","agency_talentapply_photo1","agency_talentapply_photo2","agency_talentapply_photo3",
                                               "agency_talentapply_photo4","agency_talentapply_photo5","agency_talentapply_photoreq","agency_taxid","agency_template_event","agency_template_slot_client","agency_template_slot_public",
                                               "agency_template_slot_talent","agency_url","agency_zipcode","CreatedOn","RowVersion"
                                           };

            return propertyDescriptors.AsEnumerable();
        }

        #region Properties
        
        public string agency_address
        {
            get;
            set;
        }

        public bool agency_approved
        {
            get;
            set;
        }

        public string agency_city
        {
            get;
            set;
        }

        public string agency_css
        {
            get;
            set;
        }

        public byte agency_display_nameformat
        {
            get;
            set;
        }

        public string agency_email
        {
            get;
            set;
        }

        public string agency_footer
        {
            get;
            set;
        }

        public string agency_googleanalytics
        {
            get;
            set;
        }

        public bool agency_has_favicon
        {
            get;
            set;
        }

        public bool agency_has_logo
        {
            get;
            set;
        }

        public string agency_home_text
        {
            get;
            set;
        }

        public string agency_home_title
        {
            get;
            set;
        }

        public string agency_home_youtube
        {
            get;
            set;
        }

        public string agency_join_email
        {
            get;
            set;
        }

        public string agency_join_firstname
        {
            get;
            set;
        }

        public string agency_join_lastname
        {
            get;
            set;
        }

        public int agency_level
        {
            get;
            set;
        }

        public decimal? agency_location_lat
        {
            get;
            set;
        }

        public decimal? agency_location_long
        {
            get;
            set;
        }

        public string agency_location_name
        {
            get;
            set;
        }

        public string agency_location_url
        {
            get;
            set;
        }

        public string agency_mail_welcomeapplicant
        {
            get;
            set;
        }
                
        public string agency_name
        {
            get;
            set;
        }        

        public string agency_phone
        {
            get;
            set;
        }

        public int agency_pk
        {
            get;
            set;
        }

        public int? agency_skin_compsheet
        {
            get;
            set;
        }

        public int? agency_skin_talent_private
        {
            get;
            set;
        }

        public int? agency_skin_talent_public
        {
            get;
            set;
        }

        public string agency_social_facebook
        {
            get;
            set;
        }

        public string agency_social_gplus
        {
            get;
            set;
        }

        public string agency_social_linkedin
        {
            get;
            set;
        }

        public string agency_social_twitter
        {
            get;
            set;
        }

        public string agency_social_youtube
        {
            get;
            set;
        }

        public string agency_state
        {
            get;
            set;
        }

        public string agency_talentapply_photo1
        {
            get;
            set;
        }

        public string agency_talentapply_photo2
        {
            get;
            set;
        }

        public string agency_talentapply_photo3
        {
            get;
            set;
        }

        public string agency_talentapply_photo4
        {
            get;
            set;
        }

        public string agency_talentapply_photo5
        {
            get;
            set;
        }

        public int agency_talentapply_photoreq
        {
            get;
            set;
        }

        public string agency_taxid
        {
            get;
            set;
        }

        public string agency_template_event
        {
            get;
            set;
        }

        public string agency_template_slot_client
        {
            get;
            set;
        }

        public string agency_template_slot_public
        {
            get;
            set;
        }

        public string agency_template_slot_talent
        {
            get;
            set;
        }

        public string agency_url
        {
            get;
            set;
        }

        public string agency_zipcode
        {
            get;
            set;
        }

        public DateTime? CreatedOn
        {
            get;
            set;
        }

        public byte[] RowVersion
        {
            get;
            set;
        }

        #endregion

        #region Collections
        
        public ICollection<agency_metrics_categories> agency_metrics_categories
        {
            get;
            set;
        }

        public ICollection<agency_people> agency_people
        {
            get;
            set;
        }

        public ICollection<client_dispositions> client_dispositions
        {
            get;
            set;
        }

        public ICollection<collection> collections
        {
            get;
            set;
        }

        public ICollection<domain> domains
        {
            get;
            set;
        }

        public ICollection<@event> events
        {
            get;
            set;
        }

        public ICollection<mailer> mailers
        {
            get;
            set;
        }

        public ICollection<medium> media
        {
            get;
            set;
        }

        public ICollection<page_settings> page_settings
        {
            get;
            set;
        }

        public ICollection<page> pages
        {
            get;
            set;
        }

        public ICollection<rate_types> rate_types
        {
            get;
            set;
        }

        public ICollection<testimonial> testimonials
        {
            get;
            set;
        }

        #endregion

        #region Persistable Methods
        
        public void Delete()
        {
            Delete<agency>(this);
        }

        public void Save()
        {
            Save<agency>(this);
        }

        public void Update()
        {
            Update<agency>(this, this.agency_pk);
        }

        #endregion
    }
}
