using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateEClinic.Model.Helper
{
    public static class HashCodeGenerator
    {
        public static int GenerateHashCode(params object[] keys)
        {
            int hash = 17;

            foreach (var item in keys)
            {
                int itemHashCode;
                if (item == null)
                {
                    itemHashCode = 1;
                }
                else
                {
                    itemHashCode = item.GetHashCode();
                }
                hash = hash * 23 + itemHashCode;
            }

            return hash;
        }
    }
}
