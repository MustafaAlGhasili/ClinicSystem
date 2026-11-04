using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IAppointmentStatusHistoryRepository
{
    Task<IEnumerable<AppointmentStatusHistory>> GetHistoryByAppointmentIdAsync(Guid appointmentId);
    Task AddAsync(AppointmentStatusHistory historyRecord); // Read and Append-Only
}