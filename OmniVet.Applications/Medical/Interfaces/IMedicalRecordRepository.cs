using OmniVet.Core.Entities.Medical;

namespace OmniVet.Core.Interfaces.Repository
{
    public interface IMedicalRecordRepository : IRepository<MedicalRecord>
    {
        MedicalRecord? GetByAppointment(int appointmentId);
    }
}