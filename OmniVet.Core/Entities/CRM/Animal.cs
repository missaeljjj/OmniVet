using OmniVet.Core.Entities.General;

namespace OmniVet.Core.Entities.CRM
{
    public class Animal : Entities.BaseEntity
    {
        public int AnimalId { get; set; }
        public string SpecieName { get;  private set; }

        public Animal(int animalId, string specieName) : base(id)
        {
            if (string.IsNullOrWhiteSpace(specieName))
            {
                throw new ArgumentException("La especie es obligatoria");
                SpecieName = specieName;
            }
        }
    }
}