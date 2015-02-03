using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class RegisteredUser:PersistentObject, Iv_agency_people
    {
        private RegisteredUser(v_agency_people userData) : base() 
        {
            MapProperties(this, userData);
        }

        public static RegisteredUser Authenticate(int agencyId, String email, String password, Boolean rememberMe = false, Boolean impersonate = false)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            RegisteredUser user = null;

            SqlParameter[] parameters = new SqlParameter[]{
                                                            new SqlParameter{ ParameterName = "@AGENCY", Value = agencyId },
                                                            new SqlParameter{ ParameterName = "@EMAIL", Value = email },
                                                            new SqlParameter{ ParameterName = "@PASSWORD", Value = password },
                                                            new SqlParameter{ ParameterName = "@REMEMBER", Value = rememberMe },
                                                            new SqlParameter{ ParameterName = "@IMPERSONATE", Value = impersonate }
                                                           };
            try
            {
                var authData = serviceProvider.Database.SqlQuery<v_agency_people>("exec new_people_login @AGENCY, @EMAIL, @PASSWORD, @REMEMBER, @IMPERSONATE", parameters).FirstOrDefault();

                if (authData != null)
                    user = new RegisteredUser(authData);
            }
            catch (Exception e) { throw; }

            return user;
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] descriptors = { 
                                       "people_pk", "people_firstname", "people_lastname", "people_email", "people_address", "people_address2", "people_city", "people_state", "people_postal", 
                                       "people_phone", "people_cell", "people_home_phone", "people_skype", "people_fax", "people_created", "people_auth_facebook", "people_auth_google", "people_auth_twitter", 
                                       "people_auth_openid", "people_auth_aol", "people_social_gm", "people_social_mm", "people_social_omp", "people_unique", "people_preserve", "people_birthdate", "people_formalname", 
                                       "people_joinstep", "people_password", "people_password_salt", "people_cookie", "people_manager_fk", "people_last_on", "people_facebook_link", "people_instagram_link", "people_googleplus_link", 
                                       "people_twitter_link", "people_linkedin_link", "people_guardian", "people_guardianphone", "agencypeople_pk", "agencypeople_agency_fk", "agencypeople_people_fk", "agencypeople_client_fk", "agencypeople_unique", 
                                       "agencypeople_stagename", "agencypeople_displayname", "agencypeople_notes", "agencypeople_title", "agencypeople_biography", "agencypeople_experience", "agencypeople_todo_bitmask", "agencypeople_is_exclusive", 
                                       "is_talent", "talent_is_featured", "is_agencyadmin", "is_clientadmin", "is_superadmin", "is_active", "agency_is_active", "talent_is_displayed", "is_talentmanager", "is_clientmanager", "is_applicant", "cookie", 
                                       "people_location_name", "people_location_url", "people_location_lat", "people_location_long" 
                                   };

            return descriptors.AsEnumerable();
        }

        #region Properties
        
        public String[] Roles
        {
            get
            {
                List<String> roles = new List<string>();

                if (this.is_agencyadmin == 1)
                    roles.Add("AgencyAdmin");
                if (this.is_applicant == 1)
                    roles.Add("Applicant");
                if (this.is_clientadmin == 1)
                    roles.Add("ClientAdmin");
                if (this.is_clientmanager == 1)
                    roles.Add("ClientManager");
                if (this.is_superadmin == 1)
                    roles.Add("SuperAdmin");
                if (this.is_talent  == 1)
                    roles.Add("Talent");
                if (this.is_talentmanager == 1)
                    roles.Add("TalentManager");


                return roles.ToArray(); //AgencyUserRole.GetUserRoles(this.people_pk, this.agencypeople_agency_fk);
            }
        }

        public int agency_is_active
        {
            get;
            set;
        }

        public int? agencypeople_agency_fk
        {
            get;
            set;
        }

        public string agencypeople_biography
        {
            get;
            set;
        }

        public int? agencypeople_client_fk
        {
            get;
            set;
        }

        public string agencypeople_displayname
        {
            get;
            set;
        }

        public string agencypeople_experience
        {
            get;
            set;
        }

        public bool agencypeople_is_exclusive
        {
            get;
            set;
        }

        public string agencypeople_notes
        {
            get;
            set;
        }

        public int agencypeople_people_fk
        {
            get;
            set;
        }

        public int agencypeople_pk
        {
            get;
            set;
        }

        public string agencypeople_stagename
        {
            get;
            set;
        }

        public string agencypeople_title
        {
            get;
            set;
        }

        public int? agencypeople_todo_bitmask
        {
            get;
            set;
        }

        public Guid agencypeople_unique
        {
            get;
            set;
        }

        public string cookie
        {
            get;
            set;
        }

        public int is_active
        {
            get;
            set;
        }

        public int is_agencyadmin
        {
            get;
            set;
        }

        public int is_applicant
        {
            get;
            set;
        }

        public int is_clientadmin
        {
            get;
            set;
        }

        public int is_clientmanager
        {
            get;
            set;
        }

        public int is_superadmin
        {
            get;
            set;
        }

        public int is_talent
        {
            get;
            set;
        }

        public int is_talentmanager
        {
            get;
            set;
        }

        public string people_address
        {
            get;
            set;
        }

        public string people_address2
        {
            get;
            set;
        }

        public string people_auth_aol
        {
            get;
            set;
        }

        public string people_auth_facebook
        {
            get;
            set;
        }

        public string people_auth_google
        {
            get;
            set;
        }

        public string people_auth_openid
        {
            get;
            set;
        }

        public string people_auth_twitter
        {
            get;
            set;
        }

        public DateTime? people_birthdate
        {
            get;
            set;
        }

        public string people_cell
        {
            get;
            set;
        }

        public string people_city
        {
            get;
            set;
        }

        public Guid? people_cookie
        {
            get;
            set;
        }

        public DateTime people_created
        {
            get;
            set;
        }

        public string people_email
        {
            get;
            set;
        }

        public string people_facebook_link
        {
            get;
            set;
        }

        public string people_fax
        {
            get;
            set;
        }

        public string people_firstname
        {
            get;
            set;
        }

        public string people_formalname
        {
            get;
            set;
        }

        public string people_googleplus_link
        {
            get;
            set;
        }

        public string people_guardian
        {
            get;
            set;
        }

        public string people_guardianphone
        {
            get;
            set;
        }

        public string people_home_phone
        {
            get;
            set;
        }

        public string people_instagram_link
        {
            get;
            set;
        }

        public byte people_joinstep
        {
            get;
            set;
        }

        public DateTime? people_last_on
        {
            get;
            set;
        }

        public string people_lastname
        {
            get;
            set;
        }

        public string people_linkedin_link
        {
            get;
            set;
        }

        public decimal? people_location_lat
        {
            get;
            set;
        }

        public decimal? people_location_long
        {
            get;
            set;
        }

        public string people_location_name
        {
            get;
            set;
        }

        public string people_location_url
        {
            get;
            set;
        }

        public int? people_manager_fk
        {
            get;
            set;
        }

        public byte[] people_password
        {
            get;
            set;
        }

        public Guid people_password_salt
        {
            get;
            set;
        }

        public string people_phone
        {
            get;
            set;
        }

        public int people_pk
        {
            get;
            set;
        }

        public string people_postal
        {
            get;
            set;
        }

        public bool people_preserve
        {
            get;
            set;
        }

        public string people_skype
        {
            get;
            set;
        }

        public string people_social_gm
        {
            get;
            set;
        }

        public string people_social_mm
        {
            get;
            set;
        }

        public string people_social_omp
        {
            get;
            set;
        }

        public string people_state
        {
            get;
            set;
        }

        public string people_twitter_link
        {
            get;
            set;
        }

        public Guid people_unique
        {
            get;
            set;
        }

        public int talent_is_displayed
        {
            get;
            set;
        }

        public int talent_is_featured
        {
            get;
            set;
        }

        #endregion
    }
}

