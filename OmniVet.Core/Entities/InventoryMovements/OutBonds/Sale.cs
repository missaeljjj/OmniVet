using System;
using System.Collections.Generic;
using System.Linq;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.OutBonds
{
    public class Sale : Entities.BaseEntity
    {
        private readonly List<SaleDetail> _details = new();
        private static readonly string[] EstadosValidos = { "Pagado", "Pendiente" };

        public int IdCustomer { get; private set; }
        public Customer? Customer { get; private set; }
        public DateTime SaleDate { get; private set; }
        public string SaleState { get; private set; } = "Pendiente";

        public IReadOnlyList<SaleDetail> Details => _details.AsReadOnly();
        public decimal Total => _details.Sum(d => d.Subtotal);

        public Sale(int id, int idCustomer, DateTime saleDate, Customer? customer = null) : base(id)
        {
            IdCustomer = idCustomer;
            SaleDate = saleDate;
            Customer = customer;
        }

        public void AgregarDetalle(SaleDetail detalle)
        {
            if (detalle == null)
                throw new ArgumentNullException(nameof(detalle));
            _details.Add(detalle);
        }

        public void CambiarEstado(string nuevoEstado)
        {
            if (!EstadosValidos.Contains(nuevoEstado))
                throw new ArgumentException($"Estado inválido: {nuevoEstado}");
            SaleState = nuevoEstado;
        }
    }
}