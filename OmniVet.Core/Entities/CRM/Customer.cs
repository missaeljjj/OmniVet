using OmniVet.Core.General;

namespace OmniVet.Core.CRM
{
    public class Customer : Person
    {
        public int CustomerId {get; private set;}
        public bool Status { get; set; }

        public Customer(int personid,int customerid,string firstname, string secondname, string firstlastname,
            string secondlastname, string address,bool status,Identification identification)
            : base(personid,firstname, secondname, firstlastname, secondlastname, address,identification)
        {
            CustomerId = customerid;
            Status = status;
        }
    }
}