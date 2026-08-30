using OmniVet.Core.Entities.General;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.Medical
{

    public class Specialty : Entities.BaseEntity
    {
        public string Name { get; private set; }

        public Specialty(int id, string name) : base(id)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("El nombre de la especialidad es obligatorio");
            Name = name;
        }
    }
}
  