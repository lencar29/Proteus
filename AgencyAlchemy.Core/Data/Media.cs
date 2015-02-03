using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class Media: PersistentObject, Imedium, IPersistable
    {
        private Media() : base() { }

        private Media(medium mediaData)
            : base()
        {
            MapProperties(this, mediaData);
        }

        public static Media GetNew()
        {
            return new Media();
        }

        public static Media FetchById(int id)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            Media media = null;

            try
            {
                var mediaData = provider.media.Where(m => m.media_pk == id).Single();

                media = new Media(mediaData);
            }
            catch (InvalidOperationException ioe) { }

            return media;
        }

        public static IEnumerable<Media> GetTalentMedia(int talentId, out int count, int page = 1, int pageSize = 10)
        {
            var provider = ServiceLocator.GetNew().ServiceProvider;
            List<Media> media = new List<Media>();
            int offset = (page - 1) * pageSize;
            count = 0;

            try
            {
                count = provider.media.Where(m => m.media_people_fk == talentId).Count();
                var mediaData = provider.media.Where(m => m.media_people_fk == talentId)
                                                                        .OrderBy(m => m.media_people_fk)
                                                                        .Skip(offset)
                                                                        .Take(pageSize)
                                                                        .AsEnumerable();
                                
                foreach(var data in mediaData)
                    media.Add(new Media(data));
            }
            catch (InvalidOperationException ioe) { }

            return media.AsEnumerable();
        }
        
        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = { 
                                               "agency", "media_agency_fk", "media_agency_ordinal", "media_client_fk", "media_client_ordinal", "media_created", "media_creator", 
                                               "media_event_fk", "media_event_ordinal", "media_is_local", "media_path", "media_people_fk", "media_people_ordinal", "media_pk", "media_slot_fk", 
                                               "media_thumb", "media_title", "media_type", "media_unique", "media_visible_booked", "media_visible_client", "media_visible_unbooked" 
                                           };

            return propertyDescriptors.AsEnumerable();
        }

        #region Properties
        
        public agency agency
        {
            get;
            set;
        }

        public int? media_agency_fk
        {
            get;
            set;
        }

        public int media_agency_ordinal
        {
            get;
            set;
        }

        public int? media_client_fk
        {
            get;
            set;
        }

        public int media_client_ordinal
        {
            get;
            set;
        }

        public DateTime media_created
        {
            get;
            set;
        }

        public int media_creator
        {
            get;
            set;
        }

        public int? media_event_fk
        {
            get;
            set;
        }

        public int media_event_ordinal
        {
            get;
            set;
        }

        public bool media_is_local
        {
            get;
            set;
        }

        public string media_path
        {
            get;
            set;
        }

        public int? media_people_fk
        {
            get;
            set;
        }

        public int media_people_ordinal
        {
            get;
            set;
        }

        public int media_pk
        {
            get;
            set;
        }

        public int? media_slot_fk
        {
            get;
            set;
        }

        public string media_thumb
        {
            get;
            set;
        }

        public string media_title
        {
            get;
            set;
        }

        public string media_type
        {
            get;
            set;
        }

        public Guid media_unique
        {
            get;
            set;
        }

        public bool media_visible_booked
        {
            get;
            set;
        }

        public bool media_visible_client
        {
            get;
            set;
        }

        public bool media_visible_unbooked
        {
            get;
            set;
        }

        #endregion

        #region Persistable Methods
        
        public void Delete()
        {
            Delete<medium>(this);
        }

        public void Save()
        {
            Save<medium>(this);
        }

        public void Update()
        {
            Update<medium>(this);
        }

        #endregion

    }
}
