using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;

namespace Clinic.ModelMapper.Implementations.ERP
{
    public class PaymentMapper : ClassMap<Clinic.Model.ERP.Payment>
    {
        //private const string schema = "Actions";
        public PaymentMapper()
        {
            //  SchemaIs(schema);
           
        }
    }

}