using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AgencyAlchemy.Core.Utility
{
    public class DataMapper
    {
        public static void Map(dynamic to, Object from)
        {
            if((to == null) || (from == null))
                throw new ArgumentNullException("One of the objects you are trying to map is null.");

            IEnumerable<String> propertyDescriptors = to.GetPropertyDescriptors();

            PropertyInfo[] toProperties = to.GetType().GetProperties();
            PropertyInfo[] fromProperties = from.GetType().GetProperties();
            PropertyInfo toCurrentProperty = null;
            PropertyInfo fromCurrentProperty = null;

            foreach (var property in propertyDescriptors){

                fromCurrentProperty = fromProperties.Where(x => x.Name == property).Single();
                toCurrentProperty = toProperties.Where(x => x.Name == property).Single();

                Object value = fromCurrentProperty.GetValue(from, null);

                if (value == null)
                    continue;

                toCurrentProperty.SetValue(to, value, null);
            }
        }

        public static void MapToDto(Object to, dynamic from)
        {
            if ((to == null) || (from == null))
                throw new ArgumentNullException("One of the objects you are trying to map is null.");

            IEnumerable<String> propertyDescriptors = from.GetPropertyDescriptors();

            PropertyInfo[] toProperties = to.GetType().GetProperties();
            PropertyInfo[] fromProperties = from.GetType().GetProperties();
            PropertyInfo toCurrentProperty = null;
            PropertyInfo fromCurrentProperty = null;

            foreach (var property in propertyDescriptors)
            {
                fromCurrentProperty = fromProperties.Where(x => x.Name == property).Single();
                toCurrentProperty = toProperties.Where(x => x.Name == property).Single();

                Object value = fromCurrentProperty.GetValue(from, null);

                if (value == null)
                    continue;

                toCurrentProperty.SetValue(to, value, null);
            }
        }
    }
}
