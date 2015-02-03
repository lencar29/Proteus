using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class Event:PersistentObject, Ievent, IPersistable
    {
        private Event() : base() { }

        private Event(@event eventData)
            : base()
        {
            MapProperties(this, eventData);
        }

        public static Event FetchById(int id)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            Event ev = null;

            try
            {
                var eventData = provider.events.Where(e => e.event_pk == id).Single();
                ev = new Event(eventData);
            }
            catch (InvalidOperationException ioe) { }

            return ev;
        }

        public static IEnumerable<Event> GetClientEvents(int clientId, out int count, int page = 1, int pageSize = 10)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            List<Event> events = new List<Event>();
            count = 0;

            try
            {
                var eventData = provider.events
                    .Where(e => e.event_client_fk == clientId)
                    .OrderBy(e => e.event_startdate)
                    .Skip((page-1)*pageSize)
                    .Take(pageSize)
                    .AsEnumerable();

                count = provider.events.Where(e => e.event_client_fk == clientId).Count();

                foreach(var e in eventData)
                    events.Add(new Event(e));
            }
            catch (InvalidOperationException ioe) { }

            return events.AsEnumerable();
        }

        public static IEnumerable<Event> GetAgencyEvents(int agencyId, out int count, int page = 1, int pageSize = 10)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            List<Event> events = new List<Event>();
            count = 0;

            try
            {
                var eventData = provider.events
                    .Where(e => e.event_agency_fk == agencyId)
                    .OrderByDescending(e => e.event_startdate)
                    .Skip((page - 1) * pageSize)
                    .Take(pageSize)                    
                    .AsEnumerable();

                count = provider.events.Where(e => e.event_agency_fk == agencyId).Count();

                foreach (var e in eventData)
                    events.Add(new Event(e));
            }
            catch (InvalidOperationException ioe) { }

            return events.AsEnumerable();
        }

        public static IEnumerable<Event> GetTalentParticipatingEvents(int talentId, out int count, int page = 1, int pageSize = 10)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            List<Event> events = new List<Event>();
            count = 0;

            try
            {
                var eventData = (from e in provider.events
                                 join p in provider.event_people
                                 on e.event_pk equals p.eventpeople_event_fk
                                 where p.eventpeople_people_fk == talentId
                                 select e)
                                 .OrderBy(e => e.event_startdate)
                                .Skip((page - 1) * pageSize)
                                .Take(pageSize);  
                
                count = (from e in provider.events
                                 join p in provider.event_people
                                 on e.event_pk equals p.eventpeople_event_fk
                                 where p.eventpeople_people_fk == talentId
                                 select e).Count();

                foreach (var e in eventData)
                    events.Add(new Event(e));
            }
            catch (InvalidOperationException ioe) { }

            return events.AsEnumerable();
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = { "agency", "client", "contracts", "event_agency_fk", "event_allow_freelancers", 
                                               "event_approved", "event_approvedby_fk", "event_archived", "event_archivedby_fk",
                                               "event_category1_fk", "event_category2_fk", "event_category3_fk", "event_client_fk", 
                                               "event_dates", "event_datetime_extrainfo", "event_description", "event_enddate", "event_location_address", 
                                               "event_location_city", "event_location_latitude", "event_location_longitude", "event_location_name", "event_location_state", 
                                               "event_location_zip", "event_people", "event_pk", "event_slots", "event_startdate", "event_status_fk", "event_status_forced", 
                                               "event_statuses", "event_summary", "event_title", "event_unique", "event_website" 
                                           };

            return propertyDescriptors.AsEnumerable();
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

        public ICollection<contract> contracts
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

        public DateTime? event_approved
        {
            get;
            set;
        }

        public int? event_approvedby_fk
        {
            get;
            set;
        }

        public DateTime? event_archived
        {
            get;
            set;
        }

        public int? event_archivedby_fk
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

        public ICollection<event_dates> event_dates
        {
            get;
            set;
        }

        public string event_datetime_extrainfo
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

        public ICollection<event_people> event_people
        {
            get;
            set;
        }

        public int event_pk
        {
            get;
            set;
        }

        public ICollection<event_slots> event_slots
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

        public bool event_status_forced
        {
            get;
            set;
        }

        public event_statuses event_statuses
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

        public void Delete()
        {
            Delete<@event>(this);
        }

        public void Save()
        {
            Save<@event>(this);
        }

        public void Update()
        {
            Update<@event>(this);
        }
    }
}
