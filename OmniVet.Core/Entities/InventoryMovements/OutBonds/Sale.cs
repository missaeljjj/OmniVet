namespace OmniVet.Core.InventoryMovements.OutBonds
{
    public class Sale : Transaction
    {
        public int? IdCustomer { get; set; }

        public Sale(string state, DateTime transactionDate, int? idCustomer)
        {
            State = state;
            TransactionDate = transactionDate;
            IdCustomer = idCustomer;
        }
    }

    public class SaleDetail : TrasactionDetail
    {
        public int IdSale
        {
            get;
            set => field = value > 0
                ? value
                : throw new DomainException("El IdSale es obligatorio.");
        }

        public int IdProduct
        {
            get;
            set => field = value > 0
                ? value
                : throw new DomainException("El IdProduct es obligatorio.");
        }

        public float Subtotal => UnitPrice * Quantity;

        public SaleDetail(int idSale, int idProduct, int quantity, float unitPrice)
        {
            IdSale = idSale;
            IdProduct = idProduct;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}