using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.HR
{
    public class QualifiedCertificateMapper : ClassMap<Clinic.Model.HR.QualifiedCertificate>
    {
        //private const string schema = "Actions";
        public QualifiedCertificateMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.QualifiedCertificateId);
             Map(x => x.Name)
            .WithLengthOf(100)
            .Not.Nullable();
            Map(x => x.Grade)
            .WithLengthOf(100)
            .Nullable();
     

        }
    }

}