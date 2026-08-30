using OmnitVet.Core.Shared;
using OmnitVet.Core.Exceptions;
using OmniVet.Core.Shared;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using OmniVet.Core.Exceptions;

namespace OmnitVet.Core.CRM
{
    public class Animal : IEntity<int>
    {
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