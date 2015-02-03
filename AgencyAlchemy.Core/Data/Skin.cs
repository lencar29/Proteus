using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.DataModel;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    public class Skin: PersistentObject, Iskin, IPersistable
    {
        private Skin() : base() { }

        private Skin(skin skinData)
            : base()
        {
            MapProperties(this, skinData);
        }

        public Skin GetNew()
        {
            return new Skin();
        }

        public static Skin FetchSkinById(int skinId)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            Skin skn = null;

            try
            {
                var skinData = serviceProvider.skins.Where(s => s.skin_pk == skinId).Single();

                skn = new Skin(skinData);
            }
            catch (InvalidOperationException ioe) { }

            return skn;
        }

        public static Skin[] GetMultipleSkins(params int[] skins)
        {
            var serviceProvider = ServiceLocator.GetNew().ServiceProvider;
            List<Skin> skinList = new List<Skin>();

            try
            {
                var skns = serviceProvider.skins.Where(s => skins.Contains(s.skin_pk)).ToArray();

                foreach (var skn in skns)
                    skinList.Add(new Skin(skn));

            }
            catch (InvalidOperationException ioe) { }

            return skinList.ToArray();
        }

        internal override IEnumerable<string> GetPropertyDescriptors()
        {
            String[] propertyDescriptors = { "skin_file", "skin_name", "skin_pk", "skin_type" };

            return propertyDescriptors.AsEnumerable();
        }

        public string skin_file
        {
            get;
            set;
        }

        public string skin_name
        {
            get;
            set;
        }

        public int skin_pk
        {
            get;
            set;
        }

        public string skin_type
        {
            get;
            set;
        }

        public void Delete()
        {
            Delete<skin>(this);
        }

        public void Save()
        {
            Save<skin>(this);
        }

        public void Update()
        {
            Update<skin>(this, this.skin_pk);
        }
    }
}
