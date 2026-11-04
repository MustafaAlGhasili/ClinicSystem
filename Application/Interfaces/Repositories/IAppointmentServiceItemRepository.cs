using Domain.Entities;

namespace Application.Interfaces.Repositories;

public interface IAppointmentServiceRepository
{
    Task<IReadOnlyList<AppointmentServiceItem>> GetByAppointmentIdAsync(
        Guid appointmentId,
        CancellationToken cancellationToken = default);

    Task AddRangeAsync(
        IEnumerable<AppointmentServiceItem> services,
        CancellationToken cancellationToken = default);
}