using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.CRM
{
    public class Breed : Entities.BaseEntity
    {
        public int IdAnimal { get; private set; }
        public Animal? Aniaml { get; private set; }
        public string BreedName { get; private set; }

        public Breed(int id, int idAnimal, string breedName, Animal? animal = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(breedName))
                throw new ArgumentException("La raza es obligatoria");
            IdAnimal = idAnimal;
            BreedName = breedName;
            Animal = animal;

        }
    }
}