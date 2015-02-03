using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using System.Data.Entity;
using AgencyAlchemy.Core.DataModel;

namespace AgencyAlchemy.Core.Utility
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
    public class ServiceLocator: IDisposable, IServiceLocator
    {
        private UnityContainer _container = null;
        private AlchemyEntities _repository = null;
        private Boolean _isDisposed = false;

        private ServiceLocator()
        {
            _container = new UnityContainer();
            _repository = new AlchemyEntities();            
            
            Initialize();

        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
        ~ServiceLocator()
        {            
            Dispose();
            GC.SuppressFinalize(this);
        }

        public static ServiceLocator GetNew()
        {
            return new ServiceLocator();
        }

        public AlchemyEntities ServiceProvider
        {
            get { return _repository; }
        }

        private void Initialize()
        {
            RegisterService<DbSet<person>>(_repository.people);
            RegisterService<DbSet<agency>>(_repository.agencies);
            RegisterService<DbSet<client>>(_repository.clients);
            
        }

        public void RegisterService<T>(T instance)
        {
            _container.RegisterInstance<T>(instance);
        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }


        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063:ImplementIDisposableCorrectly")]
        public void Dispose()
        {
            if (!_isDisposed)
            {
                _repository.Dispose();
                _container.Dispose();
                _isDisposed = true;
            }
        }
    }
}
