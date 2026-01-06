namespace SmartClinic.PrescriptionManagement.Domain.Entities
{
    public class Prescription
    {
        public System.Guid Id { get; set; }
        public System.Guid PatientId { get; set; }
        public string? Medication { get; set; }
    }
}
