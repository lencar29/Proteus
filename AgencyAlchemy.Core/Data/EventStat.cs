using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class EventStat: PersistentObject, Iv_event
    {
        private EventStat() :base(){}

        private EventStat(v_events eventStatData)
            : base()
        {
            MapProperties(this, eventStatData);
        }

        public static List<EventStat> GetAgencyEventStats(int agencyId, out int count, int page = 1, int pageSize = 10)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            List<EventStat> events = new List<EventStat>();
            int offset = (page - 1) * pageSize;
            count = 0;
            
            try
            {
                count = provider.v_events.Where(e => e.event_agency_fk == agencyId).Count();
                var eventData = provider.v_events.Where(e => e.event_agency_fk == agencyId)
                                                                            .OrderByDescending(e => e.event_startdate)
                                                                            .Skip(offset)
                                                                            .Take(pageSize)
                                                                            .AsEnumerable();
                                
                foreach (var evnt in eventData)
                    events.Add(new EventStat(evnt));

            }
            catch (InvalidOperationException ioe) { }

            return events;
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = { 
                                               "booked", "client_name", "event_agency_fk", "event_allow_freelancers", "event_category1_fk", "event_category2_fk", 
                                               "event_category3_fk", "event_client_fk", "event_description", "event_enddate", "event_location_address", "event_location_city", 
                                               "event_location_latitude", "event_location_longitude", "event_location_name", "event_location_state", "event_location_zip", "event_pk", 
                                               "event_startdate", "event_status_fk", "event_summary", "event_title", "event_unique", "event_website", "eventstatus_name", "manager_fk", "total" 
                                           };

            return propertyDescriptors.AsEnumerable();
        }

        #region Properties
        
        public int? booked
        {
            get;
            set;
        }

        public string client_name
        {
            get;
            set;
        }

        public int event_agency_fk
        {
            get;
            set;
        }

        public bool event_allow_freelancers
        {
            get;
            set;
        }

        public int? event_category1_fk
        {
            get;
            set;
        }

        public int? event_category2_fk
        {
            get;
            set;
        }

        public int? event_category3_fk
        {
            get;
            set;
        }

        public int? event_client_fk
        {
            get;
            set;
        }

        public string event_description
        {
            get;
            set;
        }

        public DateTime? event_enddate
        {
            get;
            set;
        }

        public string event_location_address
        {
            get;
            set;
        }

        public string event_location_city
        {
            get;
            set;
        }

        public double? event_location_latitude
        {
            get;
            set;
        }

        public double? event_location_longitude
        {
            get;
            set;
        }

        public string event_location_name
        {
            get;
            set;
        }

        public string event_location_state
        {
            get;
            set;
        }

        public string event_location_zip
        {
            get;
            set;
        }

        public int event_pk
        {
            get;
            set;
        }

        public DateTime? event_startdate
        {
            get;
            set;
        }

        public byte event_status_fk
        {
            get;
            set;
        }

        public string event_summary
        {
            get;
            set;
        }

        public string event_title
        {
            get;
            set;
        }

        public Guid event_unique
        {
            get;
            set;
        }

        public string event_website
        {
            get;
            set;
        }

        public string eventstatus_name
        {
            get;
            set;
        }

        public int? manager_fk
        {
            get;
            set;
        }

        public int total
        {
            get;
            set;
        }

        #endregion
    }
}
