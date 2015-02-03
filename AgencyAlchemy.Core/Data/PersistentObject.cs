using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using AgencyAlchemy.Core.Utility;

namespace AgencyAlchemy.Core.Data
{
    /// <summary>
    /// Base class of all objects that store and retrieve data from the database.
    /// </summary>
    public abstract class PersistentObject: IDisposable
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
         protected IServiceLocator _locator = null;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Boolean _isDisposed = false;

        public event EventHandler<EventArgs> Saving;
        public event EventHandler<EventArgs> Saved;
        public event EventHandler<EventArgs> Updating;
        public event EventHandler<EventArgs> Updated;
        public event EventHandler<EventArgs> Deleting;
        public event EventHandler<EventArgs> Deleted;

        public PersistentObject()
        {
            Initialize();
        }

        ~PersistentObject()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }

        protected virtual void Initialize()
        {
            _locator = ServiceLocator.GetNew();
        }

        /// <summary>
        /// Gets property names from Data Transfer Object (DTO) mapping.
        /// </summary>
        /// <returns>An array of property names</returns>
        internal abstract IEnumerable<String> GetPropertyDescriptors();

        /// <summary>
        /// Retieves data from a DTO and stores it in the 'to' object.
        /// </summary>
        /// <param name="to">Persistent Object to map data to</param>
        /// <param name="from">Data Transfer Objec to retrieve data from</param>
        protected void MapProperties(Object to, Object from)
        {
            DataMapper.Map(to, from);
        }

        /// <summary>
        /// Retrieves data from a Persistent Object and stores it in a DTO.
        /// </summary>
        /// <typeparam name="T">DTO to map to.</typeparam>
        /// <param name="dataObject">Persisitent Object to obtain data from.</param>
        /// <returns>The specified DTO type.</returns>
        protected T MapToDto<T>(PersistentObject dataObject)
        {
            T obj = Activator.CreateInstance<T>();

            DataMapper.MapToDto(obj, dataObject);

            return obj;
        }

        protected void Save<T>(PersistentObject dataObject)
        {
            Object obj = MapToDto<T>(dataObject);
            SaveCore(obj);
        }

        private void SaveCore(Object dataObject)
        {
            if (dataObject == null)
                return;

            try
            {
                _locator.ServiceProvider.Entry(dataObject).State = EntityState.Added;  

                OnSaving(dataObject);
                Commit();
                OnSaved(dataObject);
            }
            catch (Exception e) { throw; }
        }

        protected void Update<T>(PersistentObject dataObject, params Object[] primaryKeyValues)
        {
            UpdateCore<T>(dataObject, primaryKeyValues);
        }

        private void UpdateCore<T>(PersistentObject dataObject, params Object[] primaryKeyValues)
        {
            if (dataObject == null)
                return;            

            DbSet set = _locator.ServiceProvider.Set(typeof(T));

            try{
               Object data = set.Find(primaryKeyValues);

                if (data == null)
                    return;

                DataMapper.MapToDto(data, dataObject);

                _locator.ServiceProvider.Entry(data).State = EntityState.Modified;   

                OnUpdating(dataObject);
                Commit();
                OnUpdated(dataObject);
            }
            catch(Exception e){throw;}           
        }

        protected void Delete<T>(PersistentObject dataObject)
        {
            Object obj = MapToDto<T>(dataObject);
            DeleteCore(obj);
        }

        private void DeleteCore(Object dataObject)
        {
            if (dataObject == null)
                return;            

            try
            {
                _locator.ServiceProvider.Entry(dataObject).State = EntityState.Deleted;  

                OnDeleting(dataObject);
                Commit();
                OnDeleted(dataObject);
            }
            catch (Exception e) { throw; }          
        }

        private void Commit()
        {
            _locator.ServiceProvider.SaveChanges();
        }

        private void OnSaving(Object dataObject)
        {
            if (Saving != null)
                Saving.Invoke(dataObject, EventArgs.Empty);
        }

        private void OnSaved(Object dataObject)
        {
            if (Saving != null)
                Saved.Invoke(dataObject, EventArgs.Empty);
        }

        private void OnUpdating(Object dataObject)
        {
            if (Updating != null)
                Updating.Invoke(dataObject, EventArgs.Empty);
        }

        private void OnUpdated(Object dataObject)
        {
            if (Updated != null)
                Updated.Invoke(dataObject, EventArgs.Empty);
        }

        private void OnDeleting(Object dataObject)
        {
            if (Deleting != null)
                Deleting.Invoke(dataObject, EventArgs.Empty);
        }

        private void OnDeleted(Object dataObject)
        {
            if (Deleted != null)
                Deleted.Invoke(dataObject, EventArgs.Empty);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _locator.Dispose();
                _isDisposed = true;
            }
        }

    }
}


