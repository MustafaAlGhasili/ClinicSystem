using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IRoleRepository
{
    Task<Role?> GetByIdAsync(Guid id);
    Task<Role?> GetByNameAsync(string name);
    Task<IEnumerable<Role>> GetAllAsync();
    Task AddAsync(Role role);
    void Update(Role role);
    void Remove(Role role);
}