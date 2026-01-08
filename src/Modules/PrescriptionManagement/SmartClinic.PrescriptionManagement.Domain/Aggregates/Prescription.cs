namespace SmartClinic.PrescriptionManagement.Domain.Aggregates
{
    using System;
    using System.Collections.Generic;
    using SmartClinic.PrescriptionManagement.Domain.Events;
    using SmartClinic.PrescriptionManagement.Domain.ValueObjects;

    /// <summary>
    /// Prescription aggregate root.
    /// </summary>
    public class Prescription
    {
        public Guid Id { get; set; }
        public Guid AppointmentId { get; set; }
        public List<PrescriptionItem> Medications { get; set; } = new();
        public string? Notes { get; set; }

        // Domain events raised by this aggregate.
        public List<PrescriptionCreated> DomainEvents { get; } = new();

        public Prescription()
        {
        }

        public Prescription(Guid id, Guid appointmentId, List<PrescriptionItem> medications, string? notes = null)
        {
            Id = id;
            AppointmentId = appointmentId;
            Medications = medications ?? new List<PrescriptionItem>();
            Notes = notes;

            DomainEvents.Add(new PrescriptionCreated(id, appointmentId));
        }
    }
}
