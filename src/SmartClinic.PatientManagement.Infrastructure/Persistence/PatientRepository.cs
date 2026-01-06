using System.Collections.Concurrent;
using System.Threading.Tasks;
using SmartClinic.PatientManagement.Domain.Entities;
using SmartClinic.PatientManagement.Domain.Repositories;

namespace SmartClinic.PatientManagement.Infrastructure.Persistence
{
    // Minimal in-memory implementation of IPatientRepository for local testing/smoke tests.
    // Keeps no external dependencies and is infrastructure-only.
    public class PatientRepository : IPatientRepository
    {
        private readonly ConcurrentDictionary<System.Guid, Patient> _store = new();

        public Task AddAsync(Patient patient)
        {
            _store[patient.Id] = patient;
            return Task.CompletedTask;
        }
    }
}
