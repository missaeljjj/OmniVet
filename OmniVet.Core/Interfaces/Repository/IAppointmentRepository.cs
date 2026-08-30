using System;
using System.Collections.Generic;
using OmniVet.Core.Entities.Medical;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IAppointmentRepository : IRepository<Appointment>
    {
        IEnumerable<Appointment> GetByFecha(DateTime fecha);
        IEnumerable<Appointment> GetByEstado(EstadoCita estado);
        IEnumerable<Appointment> GetByVet(int vetId, DateTime fecha);
        void CambiarEstado(int appointmentId, EstadoCita nuevoEstado);
    }
}