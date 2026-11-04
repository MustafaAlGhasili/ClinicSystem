using Domain.Entities.RoleProfile;

namespace Application.Interfaces.Repository;

public interface IReceptionistRepository
{
    Task<Receptionist?> GetByIdAsync(Guid id);
    Task<Receptionist?> GetByUserIdAsync(Guid userId);
    Task<Receptionist?> GetByEmployeeNumberAsync(string employeeNumber);
    Task<IEnumerable<Receptionist>> GetAllAsync();
    Task AddAsync(Receptionist receptionist);
    void Update(Receptionist receptionist);
    void Remove(Receptionist receptionist);
}