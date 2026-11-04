using Domain.Entities.RoleProfile;

namespace Application.Interfaces.Repository;

public interface IDoctorRepository
{
    Task<Doctor?> GetByIdAsync(Guid id);
    Task<Doctor?> GetByUserIdAsync(Guid userId);
    Task<Doctor?> GetDoctorWithDetailsAsync(Guid id); // Includes User, Specialties, WorkingHours
    Task<IEnumerable<Doctor>> GetAllAsync();
    Task<IEnumerable<Doctor>> GetAvailableDoctorsAsync();
    Task AddAsync(Doctor doctor);
    void Update(Doctor doctor);
    void Remove(Doctor doctor);
}