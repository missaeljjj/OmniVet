using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;


namespace OmniVet.Core.CRM;
    public class Pet : IEntity<int>
    {
        public int Id { get; }

        public int IdCustomer {get; protected set;}
        public int IdBreed { get; protected set; } 

        public int IdAnimal{get; protected set;}

        public string Name
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : throw new AppDomainUnloadedException("El nombre de la mascota es obligatorio.");
        }

        public char Gender {get; set;}

        public DateTime BirthDate { get; set;}

        public Pet(int idCustomer, int idBreed, int idAnimal, string name,
            DateTime birthDate, char gender)
        {
            IdCustomer = idCustomer;
            IdBreed = idBreed;
            IdAnimal = idAnimal;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
        }
    }

