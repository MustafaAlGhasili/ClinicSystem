using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IUserRepository
{
    Task<User?> GetByIdAsync(Guid id);
    Task<User?> GetByPhoneAsync(string phone);
    Task<IEnumerable<User>> GetAllAsync();
    Task<bool> IsPhoneUniqueAsync(string phone);
    Task AddAsync(User user);
    void Update(User user);
    void Remove(User user);
}