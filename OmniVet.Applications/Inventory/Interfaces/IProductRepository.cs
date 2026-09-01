using OmniVet.Applications.Shared;
using OmniVet.Core.Inventory;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IProductRepository : IRepository<Product,int>
    {
        IEnumerable<Product> GetCriticos();
        IEnumerable<Product> GetPorCategoria(int categoryId);
        decimal GetValorTotalInventario();
        void AjustarStock(int productId, int cantidad);
    }
}