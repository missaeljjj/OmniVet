using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;

/*
namespace OmnitVet.Core.CRM
{
    public class Pet : IEntity<int>
    {
        public int Id { get; }

        public int IdCustomer
        {
            get;
            set => field = value > 0
                ? value
                : throw new AppDomainUnloadedException("El IdCustomer es obligatorio.");
        }
        public int? IdBreed { get; set; } 

        public int IdAnimal{get; set;}

        public string Name
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : throw new AppDomainUnloadedException("El nombre de la mascota es obligatorio.");
        }


        public DateTime BirthDate { get; set;}
        
        public string Observations { get; set; }

        public Pet(int idCustomer, int? idBreed, int idAnimal, string name,
            DateTime birthDate, char gender, string observations)
        {
            IdCustomer = idCustomer;
            IdBreed = idBreed;
            IdAnimal = idAnimal;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            Observations = observations;
        }
    }
}
*/