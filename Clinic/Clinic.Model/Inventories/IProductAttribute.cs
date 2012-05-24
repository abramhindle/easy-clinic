using Clinic.Infrastructure.Domain;

namespace Clinic.Model.Inventories
{
    public interface IProductAttribute 
    {
        int Id { set; get; }
        string Name { get; set; }
        
    }
}
