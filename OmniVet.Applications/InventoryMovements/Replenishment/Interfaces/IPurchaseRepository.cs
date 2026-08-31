using System;
using System.Collections.Generic;
using OmniVet.Core.Entities.Replenishment;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IPurchaseRepository : IRepository<Purchase>
    {
        IEnumerable<Purchase> GetPendientes();
        decimal GetGastoDelMes(int anio, int mes);
        Purchase? GetProximaEntrega();
    }
}