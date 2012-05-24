using Clinic.Infrastructure.Domain;

namespace Clinic.Model.Inventories
{
    public class ProductAttribute : EntityBase<int>
    {
        string Name { get; set; }
        string AttributeValue { set; get; }

        protected override void Validate()
        {
            throw new System.NotImplementedException();
        }
    }
}
