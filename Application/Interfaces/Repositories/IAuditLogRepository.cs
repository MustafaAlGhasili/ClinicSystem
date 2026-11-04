using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IAuditLogRepository
{
    Task<AuditLog?> GetByIdAsync(Guid id);
    Task<IEnumerable<AuditLog>> GetByEntityAsync(string entityName, string entityId);
    Task<IEnumerable<AuditLog>> GetByUserIdAsync(Guid userId);
    Task AddAsync(AuditLog auditLog); // Read and Append-Only
}