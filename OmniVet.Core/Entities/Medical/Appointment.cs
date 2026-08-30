using OmniVet.Core.Entities.General;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.Medical
{

    public class Appointment : Entities.BaseEntity
    {
        public int IdPet { get; private set; }
        public Pet? Pet { get; private set; }
        public int IdVet { get; private set; }
        public Vet? Vet { get; private set; }
        public int IdAppointmentTypes { get; private set; }
        public AppointmentType? AppointmentType { get; private set; }
        public DateTime AppointmentDate { get; private set; }
        public string Reason { get; private set; }
        public string? Notes { get; private set; }

        public EstadoCita Estado { get; private set; } = new CitaEnEspera();

        public Appointment(int id, int idPet, int idVet, int idAppointmentTypes, DateTime appointmentDate, string reason, string? notes = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(reason))
                throw new ArgumentException("El motivo de la cita es obligatorio");

            IdPet = idPet;
            IdVet = idVet;
            IdAppointmentTypes = idAppointmentTypes;
            AppointmentDate = appointmentDate;
            Reason = reason;
            Notes = notes;
        }

        public void CambiarEstado(EstadoCita nuevoEstado)
        {
            if (!Estado.PermiteCancelar && nuevoEstado is CitaCancelada)
                throw new InvalidOperationException($"No se puede cancelar una cita en estado {Estado.Nombre}");
            Estado = nuevoEstado;
        }
    }

}