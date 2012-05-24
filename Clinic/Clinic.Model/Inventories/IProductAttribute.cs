using Clinic.Infrastructure.Domain;

namespace Clinic.Model.Inventories
{
    public interface IProductAttribute 
    {
        int Id { set; get; }
        string Name { get; set; }
        string AttributeValue { set; get; }
        string DataType { set; get; }
    }
}
