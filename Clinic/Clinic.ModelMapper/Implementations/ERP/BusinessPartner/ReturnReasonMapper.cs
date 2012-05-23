using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using FluentNHibernate.Mapping;


namespace Clinic.Repository.NHibernate.Mapping.ERP
{
    public class ReturnReasonMapper : ClassMap<Clinic.Model.ERP.ReturnReason>
    {
        //private const string schema = "Actions";
        public ReturnReasonMapper()
        {
            
        }
    }

}