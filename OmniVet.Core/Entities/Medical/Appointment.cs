using OmnitVet.Core.Shared;
using OmnitVet.Core.Exceptions;
using OmniVet.Core.Shared;


namespace OmnitVet.Core.Entities.Medical
{
    public class Appointment :IEntity<int>
    {
        public int Id { get;}

        private int _petId;
        public int PetId
        {
            get => _petId;
            set => _petId = value > 0 ? value : throw new AppDomainUnloadedException("El PetId es obligatorio.");
        }

        private int _vetId;
        public int VetId
        {
            get => _vetId;
            set => _vetId = value > 0 ? value : throw new AppDomainUnloadedException("El VetId es obligatorio.");

        }
        private DateTime _appointmentTypeId;
        public DateTime AppointmentTypeId
        {
            get => _appointmentTypeId;
            set => _appointmentTypeId = value > 0
                ? value
                : throw new AppDomainUnloadedException("El AppointmentTypeId es obligatorio.");

        }
    }
    private DateTime _appointmentDate;
        public DateTime AppointmentDate
        {
            get => _appointmentDate;
            set => _appointmentDate = value != default
                ? value
                : throw new DomainException("La fecha de la cita es obligatoria.");
        }

        private string _reason;
        public string Reason
        {
            get => _reason;
            set => _reason = !string.IsNullOrWhiteSpace(value)
                ? value
                : throw new DomainException("El motivo de la cita es obligatorio.");
        }

        public string? Notes { get; set; } // No lleva validación

        private string _status;
        public string Status
        {
            get => _status;
            set => _status = (value == "Programada" || value == "Cancelada" || value == "Completada")
                ? value
                : throw new DomainException("El estado de la cita no es válido.");
        }

        public Appointment(int id, int petId, int vetId, int appointmentTypeId, DateTime appointmentDate,
            string reason, string? notes, string status)
        {
            Id = id;
            PetId = petId;
            VetId = vetId;
            AppointmentTypeId = appointmentTypeId;
            AppointmentDate = appointmentDate;
            Reason = reason;
            Notes = notes;
            Status = status;
        }
    }
}
}
