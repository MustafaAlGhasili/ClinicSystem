using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Application.Interfaces.Repositories;

namespace Infrastructure.Persistence.Repositories;

public class AppointmentServiceRepository(ApplicationDbContext context) : IAppointmentServiceRepository
{
    public async Task<IReadOnlyList<AppointmentServiceItem>> GetByAppointmentIdAsync(
        Guid appointmentId,
        CancellationToken cancellationToken = default)
    {
        return await context.AppointmentServices
            .Where(s => s.AppointmentId == appointmentId)
            .ToListAsync(cancellationToken);
    }

    public async Task AddRangeAsync(
        IEnumerable<AppointmentServiceItem> services,
        CancellationToken cancellationToken = default)
    {
        await context.AppointmentServices.AddRangeAsync(services, cancellationToken);
    }
}