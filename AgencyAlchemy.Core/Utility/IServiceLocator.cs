using System;
namespace AgencyAlchemy.Core.Utility
{
    public interface IServiceLocator
    {
        void Dispose();
        void RegisterService<T>(T instance);
        T Resolve<T>();
        AgencyAlchemy.Core.DataModel.AlchemyEntities ServiceProvider { get; }
    }
}
