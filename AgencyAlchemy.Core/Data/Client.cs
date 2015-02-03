using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class Client:PersistentObject, Iclient, IPersistable
    {
        private Client() : base() { }

        private Client(client clientData)
            : base()
        {
            MapProperties(this, clientData);
        }

        public static Client GetNew()
        {
            return new Client();
        }

        public static Client FetchByClientId(int clientId)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            Client clnt = null;

            try
            {
                var clientData = serviceProvider.clients.Where(c => c.client_pk == clientId).Single();
                clnt = new Client(clientData);
            }
            catch (InvalidOperationException ioe) { }

            return clnt;
        }

        public static IEnumerable<Client> GetAgencyClients(int agencyId, out int count, int page = 1, int pageSize = 10)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            List<Client> clients = new List<Client>();
            count = 0;

            try
            {
                var clientData = serviceProvider.clients
                    .Where(c => c.client_agency_fk == agencyId)
                    .OrderBy(c => c.client_name)
                    .Skip((page-1)*pageSize)
                    .Take(pageSize)
                    .AsEnumerable();

                count = serviceProvider.clients.Where(c => c.client_agency_fk == agencyId).Count();

                foreach (var data in clientData)
                    clients.Add(new Client(data));

            }
            catch (InvalidOperationException ioe) { }

            return clients.AsEnumerable();
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = { 
                                               "client_pk", "client_agency_fk", "client_logo_path", "client_name", "client_created", "client_gen_rating", "client_billing_address1", 
                                               "client_billing_address2", "client_billing_city", "client_billing_zip", "client_billing_state", "client_lat", "client_long", "client_notes", 
                                               "client_gen_events", "client_status", "client_status_date", "client_status_admin_fk", "client_is_active", "client_disposition_fk", "client_website", 
                                               "client_manager_fk", "RowVersion"
                                           };

            return propertyDescriptors.AsEnumerable();
        }

        #region Properties
        
        public int client_agency_fk
        {
            get;
            set;
        }

        public string client_billing_address1
        {
            get;
            set;
        }

        public string client_billing_address2
        {
            get;
            set;
        }

        public string client_billing_city
        {
            get;
            set;
        }

        public string client_billing_state
        {
            get;
            set;
        }

        public string client_billing_zip
        {
            get;
            set;
        }

        public DateTime client_created
        {
            get;
            set;
        }

        public int? client_disposition_fk
        {
            get;
            set;
        }

        public int? client_gen_events
        {
            get;
            set;
        }

        public double? client_gen_rating
        {
            get;
            set;
        }

        public bool client_is_active
        {
            get;
            set;
        }

        public double? client_lat
        {
            get;
            set;
        }

        public string client_logo_path
        {
            get;
            set;
        }

        public double? client_long
        {
            get;
            set;
        }

        public int? client_manager_fk
        {
            get;
            set;
        }

        public string client_name
        {
            get;
            set;
        }

        public string client_notes
        {
            get;
            set;
        }

        public int client_pk
        {
            get;
            set;
        }

        public byte? client_status
        {
            get;
            set;
        }

        public int? client_status_admin_fk
        {
            get;
            set;
        }

        public DateTime? client_status_date
        {
            get;
            set;
        }

        public string client_website
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
        
        public ICollection<collection> collections
        {
            get;
            set;
        }

        public ICollection<@event> events
        {
            get;
            set;
        }

        public ICollection<agency_people> agency_people
        {
            get;
            set;
        }

        #endregion

        #region PersistableMethods

        public void Save()
        {
            Save<client>(this);
        }

        public void Update()
        {
            Update<client>(this, this.client_pk);
        }

        public void Delete()
        {
            Delete<client>(this);
        }

        #endregion
    }
}
