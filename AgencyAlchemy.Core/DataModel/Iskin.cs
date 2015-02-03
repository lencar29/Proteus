using System;
namespace AgencyAlchemy.Core.DataModel
{
    public interface Iskin
    {
        string skin_file { get; set; }
        string skin_name { get; set; }
        int skin_pk { get; set; }
        string skin_type { get; set; }
    }
}
