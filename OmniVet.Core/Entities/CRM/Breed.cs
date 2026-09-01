using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;

using System.Runtime.CompilerServices;

namespace OmniVet.Core.CRM
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
            set => field = !string.IsNullOrWhiteSpace("El nombre de la raza es obligatorio.") switch
                {
                    true => value.Trim(),
                    false => throw new AppDomainUnloadedException("El nombre de la raza es obligatorio.")
                };
        } 

        public Breed(int idAnimal, string breedName)
        {
            IdAnimal = idAnimal;
            BreedName = breedName;
        } 
        
    }
}