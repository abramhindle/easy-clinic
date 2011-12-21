using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateEClinic.Model.Helper
{
    public static class EqualityHelper
    {
        public static bool IsEqual<T>(this T source, object obj) where T : class
        {
            var target = obj as T;
            if (obj == null)
            {
                return false;
            }
            return target.GetHashCode().Equals(source.GetHashCode());
        }
    }
}
