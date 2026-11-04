using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IAppointmentRepository
{
    Task<Appointment?> GetByIdAsync(Guid id);
    Task<Appointment?> GetByIdWithDetailsAsync(Guid id); // Includes Patient, Doctor, Services, StatusHistory
    Task<IEnumerable<Appointment>> GetByPatientIdAsync(Guid patientId);
    Task<IEnumerable<Appointment>> GetByDoctorIdAsync(Guid doctorId, DateTime? date = null);
    Task<bool> HasOverlappingAppointmentsAsync(Guid doctorId, DateTime start, DateTime end);
    Task AddAsync(Appointment appointment);
    void Update(Appointment appointment);
    void Remove(Appointment appointment);
}