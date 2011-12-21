using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace NHibernateEClinic.Model.Helper
{
    public static class ToStringHelper
    {
        public static string GetPropertiesInfo(this object instance)
        {
            Type instanceType = instance.GetType();
            IEnumerable<PropertyInfo> readableProperties = instanceType.GetProperties().Where(property => property.CanRead);
            List<string> properties = new List<string>();

            foreach (var item in readableProperties)
            {
                string name = item.Name;
                string value = item.GetValue(instance, null) + "";
                properties.Add(string.Format("{0} = {1}", item.Name, value));
            }

            string output = string.Format("{0} : [{1}] ", instanceType.Name, string.Join(",", properties.ToArray()));

            return output;
        }
    }
}
