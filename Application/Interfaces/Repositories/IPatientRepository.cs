using Domain.Entities.RoleProfile;

namespace Application.Interfaces.Repository;

public interface IPatientRepository
{
    Task<Patient?> GetByIdAsync(Guid id);
    Task<Patient?> GetByUserIdAsync(Guid userId);
    Task<IEnumerable<Patient>> GetAllAsync();
    Task AddAsync(Patient patient);
    void Update(Patient patient);
    void Remove(Patient patient);
}