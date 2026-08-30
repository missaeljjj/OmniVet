using OmnitVet.Core.Exceptions;
using OmniVet.Core.Exceptions;

namespace OmnitVet.Core.InventoryMovements.Replenishment
{
    public class Purchase : Transaction
    {
        public int IdSupplier
        {
            get;
            set => field = value > 0
                ? value
                : throw new AppDomainUnloadedException("El IdSupplier es obligatorio.");
        }
        public Purchase(string state, DateTime transactionDate, int idSupplier)
        {
            State = state;
            TransactionDate = transactionDate;
            IdSupplier = idSupplier;
        }
    }
    public class PurchaseDetail : TrasactionDetail
    {
        public int IdPurchase
        {
            get;
            set => field = value > 0
                ? value
                : throw new DomainException("El IdPurchase es obligatorio.");
        }
        public int IdProduct
        {
            get;
            set => field = value > 0
                ? value
                : throw new DomainException("El IdProduct es obligatorio.");
        }
        public float Subtotal => UnitPrice * Quantity;

        public PurchaseDetail(int idPurchase, int idProduct, int quantity, float unitCost )
        {
            IdPurchase = idPurchase;
            IdProduct = idProduct;
            Quantity = quantity;
            UnitPrice = unitCost;
        }
    }
}