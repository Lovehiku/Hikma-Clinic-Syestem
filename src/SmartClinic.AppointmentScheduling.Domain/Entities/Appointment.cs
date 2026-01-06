namespace SmartClinic.AppointmentScheduling.Domain.Entities
{
    public class Appointment
    {
        public System.Guid Id { get; set; }
        public System.DateTime Start { get; set; }
        public System.DateTime End { get; set; }
    }
}
