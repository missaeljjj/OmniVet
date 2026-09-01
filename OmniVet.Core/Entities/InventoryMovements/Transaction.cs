using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;

namespace OmnitVet.Core.InventoryMovements;

public abstract class Transaction : IEntity<int>
{
    public int Id { get; }

    public int Total { get; }

    public string State { get; set; }

    public DateTime TransactionDate
    {
        get;
        set => field = value > DateTime.Now
            ? throw new DomainException("La fecha de la transaccion no puede ser mayor al dia de hoy")
            : value;
    }
}

//class for transactions detail use for purchase and sales
public abstract class TrasactionDetail : IEntity<int>
{
    public int Id { get; }

    public int Quantity
    {
        get;
        set => field = value;
    }

    public float UnitPrice
    {
        get;
        set => field = value > 0 switch
        {
            true => throw new DomainException("El precio no puede ser cero"),
            _ => field = value
        };

          
    }
}