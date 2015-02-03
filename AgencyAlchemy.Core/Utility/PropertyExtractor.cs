using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgencyAlchemy.Core.Utility
{
    public class PropertyExtractor
    {
        public static String GetProperties(Type obj)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");

            foreach(var prop in obj.GetProperties())
            {
                sb.Append(String.Format(@"""{0}"",", prop.Name));
            }
            sb.Append("}");

            return sb.ToString();
        }
    }
}
