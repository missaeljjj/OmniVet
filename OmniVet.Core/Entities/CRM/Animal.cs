using OmniVet.Core.Shared;
using OmniVet.Core.Exceptions;
using System.Globalization;
using System.ComponentModel.DataAnnotations;


namespace OmniVet.Core.CRM
{
    public class Animal : IEntity<int>
    {
        public int Id { get; }
        public string SpecieName
        {
            get;
            set => field = !string.IsNullOrWhiteSpace(value)
                ? value.Trim()
                : throw new DomainException("El nombre de la especie es obligataria.");
        }
        public Animal (string specieName)
        {
            SpecieName = specieName;
        } 
    } 

      
}