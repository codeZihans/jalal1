using DevSkill.Inventory.Domain.Entities;

namespace DevSkill.Inventory.Application.Services
{
    public interface IProductManagementService
    {
        void CreateProduct(Product product);
    }
}