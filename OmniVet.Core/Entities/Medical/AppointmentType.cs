using OmniVet.Core.Entities.General;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.Medical
{

    public class AppointmentType : Entities.BaseEntity
    {
        public string Name { get; private set; }
        public string? Description { get; private set; }

        public AppointmentType(int id, string name, string? description = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El tipo de cita es obligatorio");
            Name = name;
            Description = description;
        }
    }

 
}