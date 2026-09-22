using OmniVet.Core.General;

namespace OmniVet.Core.InventoryMovements.Replenishment
{
    public class Supplier : Person
    {
        public bool Status { get; set; } = true;

        public Supplier(int personid,string firstname, string secondame, string firstlastname,
            string secondlastname, string address,bool status)
            : base (personid,firstname, secondame, firstlastname, secondlastname, address)
        {
            Status = status;
        }
    }
}