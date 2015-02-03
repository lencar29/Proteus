using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    /// <summary>
    /// The User Profile contains such information as a user's biography and experience.
    /// </summary>
    public class UserProfile : PersistentObject, Iagency_people, IPersistable
    {
        private UserProfile() : base() { }

        private UserProfile(agency_people apData)
            : base()
        {
            MapProperties(this, apData);
        }

        /// <summary>
        /// Creates a new instance of a Useer Profile.
        /// </summary>
        /// <returns></returns>
        public static UserProfile GetNew()
        {
            return new UserProfile();
        }

        /// <summary>
        /// Retrieves a user's profile based on the user's agency and role.
        /// </summary>
        /// <param name="agencyId">The ID of the agency to which the user belongs.</param>
        /// <param name="userId">The ID of the user whose profile it to be retrieved.</param>
        /// <param name="roleId">The ID of the role in which the user has.</param>
        /// <returns>A user's profile based on the forementioned parameters.</returns>
        public static UserProfile FetchByAgenyUserIdAndRole(int agencyId, int userId, int roleId)
        {
            UserProfile profile = null;
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;

            try
            {
                var profileData = (
                                      from ap in serviceProvider.agency_people
                                      join r in serviceProvider.agency_people_roles  
                                       on ap.agencypeople_people_fk equals r.people_pk
                                      where (ap.agencypeople_agency_fk == agencyId &&
                                      r.people_pk == userId && r.role_pk == roleId)
                                      select ap
                                  ).Single();

                profile = new UserProfile(profileData);
            }
            catch (InvalidOperationException ioe) { } // This exception should not be thrown as it occurs when there are no
                                                      // records to retrieve from the database.

            return profile;
        }

        /// <summary>
        /// Retrieves a user's profile by his or her Profile ID.
        /// </summary>
        /// <param name="profileId">The Profile ID of the user's data to retrieve.</param>
        /// <returns>A user's profile based on the Profile ID.</returns>
        public static UserProfile FetchByProfileId(int profileId)
        {
            UserProfile profile = null;
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;

            try
            {
                var profileData = serviceProvider.agency_people.Where(ap => ap.agencypeople_pk == profileId).Single();
                profile = new UserProfile(profileData);
            }
            catch (InvalidOperationException ioe) { } // This exception should not be thrown as it occurs when there are no
                                                      // records to retrieve from the database.

            return profile;
        }


        /// <summary>
        /// Retrieves the user profiles of an agency, which allows for pagination.
        /// </summary>
        /// <param name="agencyId">The ID of the agency in which to obtain profiles for.</param>
        /// <param name="count">The total count of an agency's profiles</param>
        /// <param name="page">The page at which to start retrieving items.</param>
        /// <param name="pageSize">Number of items to return in the array.</param>
        /// <returns>An array of agency users' profiles</returns>
        public static IEnumerable<UserProfile> FetchByAgencyId(int agencyId, out int count, int page = 1, int pageSize = 10)
        {
            List<UserProfile> profiles = new List<UserProfile>();
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;            
            int offset = (page - 1) * pageSize;
            count = 0;
            
            try
            {
                count = serviceProvider.agency_people.Where(ap => ap.agencypeople_agency_fk == agencyId).Count();
                var profileData = serviceProvider.agency_people.Where(ap => ap.agencypeople_agency_fk == agencyId)
                                                                                                    .OrderBy(p => p.agencypeople_pk)
                                                                                                    .Skip(offset)
                                                                                                    .Take(pageSize)
                                                                                                    .ToArray();
                                
                foreach (var data in profileData)
                    profiles.Add(new UserProfile(data));
            }
            catch (InvalidOperationException ioe) { } // This exception should not be thrown as it occurs when there are no
                                                      // records to retrieve from the database.

            return profiles.AsEnumerable();
        }

        /// <summary>
        /// Retrieves the independent talented individuals that are in the system.
        /// </summary>
        /// <param name="count">The total count of freelancers' profiles</param>
        /// <param name="page">The page at which to start retrieving items.</param>
        /// <param name="pageSize">The number of user profiles to place in the array.</param>
        /// <returns>An array of independent users' profiles</returns>
        public static IEnumerable<UserProfile> FetchFreeLancers(out int count, int page = 1, int pageSize = 10)
        {
            List<UserProfile> profiles = new List<UserProfile>();
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            int offset = (page - 1) * pageSize;
            count = 0;

            try
            {
                count = serviceProvider.agency_people.Where(ap => ap.agencypeople_agency_fk == null).Count();
                var profileData = serviceProvider.agency_people.Where(ap => ap.agencypeople_agency_fk == null)
                                                                                                .OrderBy(p => p.agencypeople_people_fk)
                                                                                                .Skip(offset)
                                                                                                .Take(pageSize)
                                                                                                .ToArray();                            

                foreach (var data in profileData)
                    profiles.Add(new UserProfile(data));
            }
            catch (InvalidOperationException ioe) { } // This exception should not be thrown as it occurs when there are no
            // records to retrieve from the database.

            return profiles.AsEnumerable();
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = { 
                                               "agencypeople_agency_fk", "agencypeople_applicant_eventslot_fk", "agencypeople_biography", "agencypeople_client_fk", 
                                               "agencypeople_created", "agencypeople_displayname", "agencypeople_experience", "agencypeople_is_exclusive", "agencypeople_notes", 
                                               "agencypeople_people_fk", "agencypeople_pk", "agencypeople_stagename", "agencypeople_title", "agencypeople_todo_bitmask",
                                               "agencypeople_unique", "agency", "client", "person", "agency_people_rates", "flags" 
                                           };

            return propertyDescriptors;
        }

        #region Properties
        
        public int? agencypeople_agency_fk
        {
            get;
            set;
        }

        public int? agencypeople_applicant_eventslot_fk
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

        public DateTime? agencypeople_created
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

        public agency agency
        {
            get;
            set;
        }

        public client client
        {
            get;
            set;
        }
                
        public person person
        {
            get;
            set;
        }

        #endregion

        #region Colletions
        
        public ICollection<agency_people_rates> agency_people_rates
        {
            get;
            set;
        }

        public ICollection<flag> flags
        {
            get;
            set;
        }

        #endregion

        #region Persistable Methods
        
        public void Delete()
        {
            Delete<agency_people>(this);
        }

        public void Save()
        {
            Save<agency_people>(this);
        }

        public void Update()
        {
            Update<agency_people>(this, this.agencypeople_pk);
        }

        #endregion
    }
}
