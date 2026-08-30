using OmnitVet.Core.Shared;
using OmnitVet.Core.Exceptions;
using OmniVet.Core.Shared;
using System.Runtime.CompilerServices;

namespace OmnitVet.Core.CRM
{
    public class Breed : IEntity<int>
    {
        public int Id { get; }

        public int IdAnimal
        {
            get;
            set => field = value > 0
                ? value
                : throw new AppDomainUnloadedException("El IdAnimal es obligatorio.");

        }
        public string BreedName
        {
            get;
            set => field = !string.IsNullOrWhiteSpace("El nombre de la raza es obligatorio.");
        } 

        public Breed(int idAnimal, string breedName)
        {
            IdAnimal = idAnimal;
            BreedName = breedName;
        } 
        
    }
}