namespace SmartClinic.PatientManagement.Domain.Entities
{
    public class Patient
    {
        public System.Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
