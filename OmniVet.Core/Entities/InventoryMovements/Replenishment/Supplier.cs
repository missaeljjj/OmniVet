using OmniVet.Core;

namespace OmnitVet.Core.InventoryMovements.Replenishment
{
    public class Supplier : Person
    {
        public bool Status { get; set; } = true;

        public Supplier(string firstname, string secondame, string firstlastname,
            string secondlastname, string address)
            : base (firstname, secondame, firstlastname, secondlastname, address)
        {
        }
    }
}