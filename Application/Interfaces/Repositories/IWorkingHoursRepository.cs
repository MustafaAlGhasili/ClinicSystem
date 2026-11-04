using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IWorkingHoursRepository
{
    Task<WorkingHours?> GetByIdAsync(Guid id);
    Task<IEnumerable<WorkingHours>> GetByDoctorIdAsync(Guid doctorId);
    Task<WorkingHours?> GetDoctorHoursForDayAsync(Guid doctorId, DayOfWeek dayOfWeek);
    Task AddAsync(WorkingHours workingHours);
    void Update(WorkingHours workingHours);
    void Remove(WorkingHours workingHours);
}