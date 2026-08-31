using System.Collections.Generic;
using OmniVet.Core.Entities.Inventory;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetCriticos();
        IEnumerable<Product> GetPorCategoria(int categoryId);
        decimal GetValorTotalInventario();
        void AjustarStock(int productId, int cantidad);
    }
}