using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Infrastructure.Domain;

namespace Clinic.Model.Inventories
{
    public class ProductTitle : EntityBase<int>, IAggregateRoot
    {
        public string Name { set; get; }
        public IEnumerable<Product> Products { set; get; }
        public IEnumerable<ProductAttribute> Attributes { set; get; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
