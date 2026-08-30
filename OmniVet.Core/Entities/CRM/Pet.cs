using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.CRM
{
    public class Pet : Entities.BaseEntity
    {
        public int IdCustomer { get; private set; }
        public Customer ? Customer { get; private set; }
        public int? IdBreed { get; private set; }
        public Breed? Breed { get; private set; }
        public int IdAnimal { get; private set; }
        public Animal? Animal { get; private set; }
        public string Name { get; private set; }
        public DateTime BirthDate { get; private set; }
        public char Gender { get; private set; }
        public string? Observations { get; private set; }

        public Pet(int id, int idCustomer, int idAnimal, string name, DateTime birthDate, char gender, int? idBreed = null, string? observations = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre de la mascota es obligatorio");
            if (birthDate > DateTime.Now)
                throw new ArgumentException("La fecha de nacimiento no puede ser futura");
            if (gender !== 'M' && gender != 'F')
                throw new ArgumentException("Genero invalido, por favor, use 'M' o 'F' ");

            IdCustomer = idCustomer;
            IdAnimal = idAnimal;
            Name = name;
            BirthDate = birthDate;
            Gender = gender;
            IdBreed = idBreed;
            Observations = observations;
        }

        public int EdadEnAnios() => (int) (DateTime.Now - BirthDate).TotalDays / 365.25);
    }
}