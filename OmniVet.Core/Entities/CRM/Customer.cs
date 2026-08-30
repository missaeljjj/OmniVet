using OmniVet.Core.Entities.General;

namespace OmniVet.Core.Entities.CRM
{
    public class Customer : Entities.BaseEntity
    {
        public int CustomerId { get; set; }
        public int IdPerson { get; set; }
        public Person? Person { get; set; }
        public bool Status { get; set; }

        public Customer(int customerId, int idPerson, Person? person = null): base(id)
        {
            CustomerId = customerId;
            Person = person;
            Status = true;
        }
        public void Activate() => Status = true;
        public void Deactivate() => Status = false;
    }
}