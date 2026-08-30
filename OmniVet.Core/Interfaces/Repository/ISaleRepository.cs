using System;
using System.Collections.Generic;
using OmniVet.Core.Entities.OutBonds;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface ISaleRepository : IRepository<Sale>
    {
        Sale? GetUltimaVenta();
        IEnumerable<Sale> GetByFecha(DateTime desde, DateTime hasta);
        decimal GetIngresoDelDia(DateTime fecha);
        decimal GetTotalDelMes(int anio, int mes);
        decimal GetTicketPromedio(DateTime fecha);
    }
}}
