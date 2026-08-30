using OmniVet.Core;

namespace OmnitVet.Core.CRM
{
    public class Customer : Person
    {
        public bool Status { get; set; } = true;

        public Customer(string firstname, string secondname, string firstlastname,
            string secondlastname, string address)
            : base(firstname, secondname, firstlastname, secondlastname, address )
        {
        }
    }
}