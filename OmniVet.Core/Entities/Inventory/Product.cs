using OmniVet.Core.Entities.Inventory;

namespace OmniVet.Core.Entities.Inventory
{
    public class Product : Entities.BaseEntity
    {
        private int _stock;
        private decimal _unitPrice;

        public int IdCategory { get; private set; }
        public Category? Category { get; private set; }
        public string Name { get; private set; }
        public string? Description { get; private set; }
        public int MinimumStock { get; private set; }
        public bool Status { get; private set; }

        public int Stock
        {
            get => _stock;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El stock no puede ser negativo.");
                }
                _stock = value;
            }
        }

        public decimal UnitPrice
        {
            get => _unitPrice;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("El precio unitario no puede ser negativo.");
                }
                _unitPrice = value;
            }
        }

        public Product(int id, int idCategory, string name, string? description, int minimumStock, bool status, int stock, decimal unitPrice) : base(id)
        {
            IdCategory = idCategory;
            Name = name;
            Description = description;
            MinimumStock = minimumStock;
            Status = true;
            Stock = stock;
            UnitPrice = unitPrice;

        }

        public void AdjustStock(int cantidad)
        {
            var nuevoStock = _stock + cantidad;
            if (nuevoStock < 0)
            {
                throw new ArgumentException("No hay suficiente stock disponible.")
            }
            Stock = nuevoStock;
        }

        public string CalculateStatus()
        {
            Stock <= MinimumStock ? "CRITICO" :
                Stock <= MinimumStock * 1.5 ? "BAJO" : "NORMAL";
        }
    }
}