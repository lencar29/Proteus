using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class AgencyUserRole:PersistentObject, Iagency_people_roles, IPersistable
    {
        private AgencyUserRole() : base() { }

        private AgencyUserRole(agency_people_roles roleData)
            : base()
        {
            MapProperties(this, roleData);
        }

        public static AgencyUserRole GetNew()
        {
            return new AgencyUserRole();
        }

        public static AgencyUserRole GetUserRole(int roleId)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            AgencyUserRole role = null;

            try
            {
                var roleData = provider.agency_people_roles.Where(r => r.agency_people_role_pk == roleId).Single();

                role = new AgencyUserRole(roleData);
            }
            catch (InvalidOperationException ioe) { }

            return role;
        }

        public static String[] GetUserRoles(int userId, int? agencyId = null)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            String[] roles = null;

            try{
                roles = (
                            from r in provider.roles
                            join a in provider.agency_people_roles
                            on r.RoleId equals a.role_pk 
                            where (a.agency_pk == agencyId || a.agency_pk == null)  &&
                            a.people_pk == userId
                            select r.Name
                    ).ToArray();
            }
            catch(InvalidOperationException ioe){}

            return roles;
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = {
                                               "agency","agency_people_role_pk","agency_pk","people_pk","person","role","role_pk"
                                           };

            return propertyDescriptors.AsEnumerable();
        }

        #region Properties
        
        public agency agency
        {
            get;
            set;
        }

        public int agency_people_role_pk
        {
            get;
            set;
        }

        public int? agency_pk
        {
            get;
            set;
        }

        public int people_pk
        {
            get;
            set;
        }

        public person person
        {
            get;
            set;
        }

        public role role
        {
            get;
            set;
        }

        public int role_pk
        {
            get;
            set;
        }

        #endregion

        #region Persistable Methods
        
        public void Delete()
        {
            Delete<agency_people_roles>(this);
        }

        public void Save()
        {
            Save<agency_people_roles>(this);
        }

        public void Update()
        {
            Update<agency_people_roles>(this);
        }

        #endregion
    }
}
