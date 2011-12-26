using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinic.Model.ERP
{
    /// <summary>
    /// Nhom hang
    /// </summary>
    public class ProductGroup
    {
        public int ProductGroupId { set; get; }
        public ProductIndustry ProductIndustry { set; get; }
        public string Name { set; get; }
        public string Note { set; get; }       
        public Discount Discount { set; get; }
        public decimal Tax { set; get; }

    }
}

using FluentNHibernate.Mapping;


namespace Clinic.ModelMapper.Implementations.ERP
{
    public class ProductGroupMapper : ClassMap<Clinic.Model.ERP.ProductGroup>
    {
        //private const string schema = "Actions";
        public ProductGroupMapper()
        {
            //  SchemaIs(schema);
            Id(x => x.ProductGroupId);
            References(x => x.ProductIndustry)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Name)
                .WithLengthOf(100)
                .Nullable();
            Map(x => x.Note)
                .WithLengthOf(100)
                .Nullable();
            References(x => x.Discount)
                //.LazyLoad()
               .Nullable();
            Map(x => x.Tax)
                .Nullable();

        }
    }

}
