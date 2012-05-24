using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinic.Infrastructure.Domain;

namespace Clinic.Model.Inventories
{
    public class ProductAttribute : EntityBase<int>, IProductAttribute
    {
        public string Name { set; get; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
