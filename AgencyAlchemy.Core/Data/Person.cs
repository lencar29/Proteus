using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.Utility;
using AgencyAlchemy.Core.DataModel;

namespace AgencyAlchemy.Core.Data
{
    public partial class Person : PersistentObject, Iperson, IPersistable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Person _manager = null;

        internal Person()
            : base()
        {
            this.people_created = DateTime.Now;
        }

        private Person(person personData)
            : base()
        {
            MapProperties(this, personData);
        }

        public static Person GetNew()
        {
            return new Person();
        }

        public static Person FetchPersonById(int id)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            Person user = null;

            try
            {
                var personData = serviceProvider.people.Where(p => p.people_pk == id).Single();

                user = new Person(personData as person);
            }
            catch (InvalidOperationException ioe) { } 

            return user;
        }
        
        public Person manager
        {
            get
            {
                if (_manager == null)
                {
                    try
                    {
                        var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
                        var personData = serviceProvider.people.Where(p => p.people_pk == this.people_manager_fk).Single();                                       
                                       
                        _manager = new Person(personData as person);
                    }
                    catch (InvalidOperationException ioe) { }
                }
                return _manager;
            }
        }

        internal override IEnumerable<String> GetPropertyDescriptors()
        {

            String[] descriptors = {
                                        "people_address", "people_address2", "people_auth_aol", "people_auth_facebook", "people_auth_google", "people_auth_openid", "people_auth_twitter",
                                        "people_birthdate", "people_cell", "people_city", "people_cookie", "people_created", "people_email", "people_facebook_link", "people_fax",
                                        "people_joinstep", "people_last_on", "people_lastname", "people_linkedin_link", "people_location_lat", "people_location_long", "people_location_name",
                                        "people_location_url", "people_manager_fk", "people_phone", "people_pk", "people_postal", "people_preserve", "people_skype", "people_social_gm",
                                        "people_social_mm", "people_social_omp", "people_state", "people_twitter_link", "people_unique"
                                    };

            return descriptors.AsEnumerable();
        }

        public void CreateAgencyAccount(AgencyAccountSettings settings, String password)
        {
            
        }      

        #region Properties

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

        #endregion

        #region Collections

        public ICollection<people_locations> people_locations
        {
            get;
            set;
        }
        
        public ICollection<private_notes> private_notes
        {
            get;
            set;
        }

        public ICollection<testimonial> testimonials
        {
            get;
            set;
        }

        public ICollection<agency_people> agency_people
        {
            get;
            set;
        }

        public ICollection<collectiontalent> collectiontalents
        {
            get;
            set;
        }

        public ICollection<contract> contracts
        {
            get;
            set;
        }

        public ICollection<event_people> event_people
        {
            get;
            set;
        }

        public ICollection<metrics_custom> metrics_custom
        {
            get;
            set;
        }

        public ICollection<note> notes
        {
            get;
            set;
        }

        public ICollection<people_rating> people_rating
        {
            get;
            set;
        }

        public ICollection<people_rating> people_rating1
        {
            get;
            set;
        }

        public ICollection<people_metrics> people_metrics
        {
            get;
            set;
        }

        #endregion

        #region PersistableMethods

        public void Save()
        {
            Save<person>(this);
        }

        public void Update()
        {
            Update<person>(this, this.people_pk);
        }

        public void Delete()
        {
            Delete<person>(this);
        }

        #endregion
    }
}