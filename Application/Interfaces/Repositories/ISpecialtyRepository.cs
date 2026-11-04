using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface ISpecialtyRepository
{
    Task<Specialty?> GetByIdAsync(Guid id);
    Task<IEnumerable<Specialty>> GetAllAsync();
    Task<IEnumerable<Specialty>> GetActiveSpecialtiesAsync();
    Task AddAsync(Specialty specialty);
    void Update(Specialty specialty);
    void Remove(Specialty specialty);
}