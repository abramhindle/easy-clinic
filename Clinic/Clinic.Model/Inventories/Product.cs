using System;
using System.Collections.Generic;
using Clinic.Infrastructure.Domain;
using Clinic.Model.ERP;

namespace Clinic.Model.Inventories
{
    public class Product : EntityBase<int>, IAggregateRoot
    {
        public string Sku { set; get; }
        public string PartNumber { set; get; }

        public ProductTitle ProductTitle { set; get; }
        public IEnumerable<ProductAttribute> Attributes { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public string Note { set; get; }
        public string Picture { set; get; }
        public bool IsSuppliment { set; get; }
        public bool IsPurchase { set; get; }
        public Protection Protection { set; get; }
        public string Position { set; get; }

        public UnitOfMeansure Unit { set; get; }


        public decimal Tax { set; get; }

        public List<Product> Dependencies { set; get; }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
