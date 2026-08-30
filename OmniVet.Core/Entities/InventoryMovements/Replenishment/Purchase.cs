using System;
using System.Collections.Generic;
using System.Linq;

namespace OmniVet.Core.Entities.Replenishment
{
    public class Purchase : Entities.BaseEntity
    {
        private readonly List<PurchaseDetail> _details = new();
        private static readonly string[] EstadosValidos = { "Pendiente", "En Tránsito", "Recibido" };

        public int IdSupplier { get; private set; }
        public Supplier? Supplier { get; private set; }
        public DateTime PurchaseDate { get; private set; }
        public string PurchaseState { get; private set; } = "Pendiente";

        public IReadOnlyList<PurchaseDetail> Details => _details.AsReadOnly();
        public decimal Total => _details.Sum(d => d.Subtotal);

        public Purchase(int id, int idSupplier, DateTime purchaseDate, Supplier? supplier = null) : base(id)
        {
            IdSupplier = idSupplier;
            PurchaseDate = purchaseDate;
            Supplier = supplier;
        }

        public void AgregarDetalle(PurchaseDetail detalle)
        {
            if (detalle == null)
                throw new ArgumentNullException(nameof(detalle));
            _details.Add(detalle);
        }

        public void CambiarEstado(string nuevoEstado)
        {
            if (!EstadosValidos.Contains(nuevoEstado))
                throw new ArgumentException($"Estado inválido: {nuevoEstado}");
            PurchaseState = nuevoEstado;
        }
    }
}