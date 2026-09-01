using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;

namespace OmniVet.Core.Inventory
{
    public class Product : IEntity<int>
    {
        public int Id { get; }

        public int IdCategory
        {
            get;
            set => field = value > 0
                ? value
                : throw new AppDomainUnloadedException("El IdCategory es obligatoria.");
        }
        public string Name
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : throw new AppDomainUnloadedException("El nombre del producto es obligatorio.");
        }
        public string Description { get; set; } 

        public int Stock
        {
            get;
            set => field = value >= 0
                ? value
                : throw new AppDomainUnloadedException("El stock no puede ser negativo.");
        }
        public decimal UnitPrice
        {
            get;
            set => field = value >= 0
                ? value
                : throw new AppDomainUnloadedException("El precio unitario no puede ser negativo.");
        }
        public bool Status { get; set; } = true;

        public Product (int idCategory, string name, string description, int stock,  decimal unitPrice)
        {
            IdCategory = idCategory;
            Name = name;
            Description = description;
            Stock = stock;
            UnitPrice = unitPrice;
        }
    }
}