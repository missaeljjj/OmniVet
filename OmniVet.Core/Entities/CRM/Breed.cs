using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;

namespace OmniVet.Core.CRM;

public sealed class Breed : IEntity<int>
{
    public int Id { get; }

    public int IdAnimal {get; set;}

        public string BreedName
        {
            get;
            set => field = !string.IsNullOrWhiteSpace("El nombre de la raza es obligatorio.") switch
                {
                    true => value.Trim(),
                    false => throw new DomainException("El nombre de la raza es obligatorio.")
                };
        } 

        public Breed(int id,int idAnimal, string breedName)
        {
            Id = id;
            IdAnimal = idAnimal;
            BreedName = breedName;
        } 
        
    }
