using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IDoctorSpecialtyRepository
{
    Task<IEnumerable<DoctorSpecialty>> GetByDoctorIdAsync(Guid doctorId);
    Task<IEnumerable<DoctorSpecialty>> GetBySpecialtyIdAsync(Guid specialtyId);
    Task AddAsync(DoctorSpecialty doctorSpecialty);
    void Remove(DoctorSpecialty doctorSpecialty);
}