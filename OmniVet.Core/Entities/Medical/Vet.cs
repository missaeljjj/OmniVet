using OmniVet.Core.Entities.General;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.Medical
{
    public class Vet : Entities.BaseEntity
    {
        public int IdPerson { get; private set; }
        public Person? Person { get; private set; }
        public string MedicalLicense { get; private set; }
        public DateTime HireDate { get; private set; }
        public bool Status { get; private set; }

        public Vet(int id, int idPerson, string medicalLicense, DateTime hireDate, Person? person = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(medicalLicense))
                throw new ArgumentException("La licencia médica es obligatoria");
            IdPerson = idPerson;
            MedicalLicense = medicalLicense;
            HireDate = hireDate;
            Person = person;
            Status = true;
        }

        public void Activar() => Status = true;
        public void Desactivar() => Status = false;
    }

}    