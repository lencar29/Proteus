using System;
namespace AgencyAlchemy.Core.Data
{
    public interface IPersistable
    {
        void Delete();
        void Save();
        void Update();
    }
}
