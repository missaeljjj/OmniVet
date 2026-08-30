using OmniVet.Core.Entities.General;
using OmniVet.Core.Entities.CRM;

namespace OmniVet.Core.Entities.Medical
{
    public class MedicalRecord : Entities.BaseEntity
    {
        public int IdAppointment { get; private set; }
        public Appointment? Appointment { get; private set; }
        public decimal? Weight { get; private set; }
        public decimal? Temperature { get; private set; }
        public string Diagnosis { get; private set; }
        public string? Treatment { get; private set; }
        public string? Notes { get; private set; }
        public DateTime RecordDate { get; private set; } = DateTime.Now;

        public MedicalRecord(int id, int idAppointment, string diagnosis, decimal? weight = null, decimal? temperature = null, string? treatment = null, string? notes = null) : base(id)
        {
            if (string.IsNullOrWhiteSpace(diagnosis))
                throw new ArgumentException("El diagnóstico es obligatorio");
            IdAppointment = idAppointment;
            Diagnosis = diagnosis;
            Weight = weight;
            Temperature = temperature;
            Treatment = treatment;
            Notes = notes;
        }
    }
}