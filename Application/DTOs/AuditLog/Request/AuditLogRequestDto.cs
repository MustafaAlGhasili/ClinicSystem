namespace Application.DTOs.AuditLog.Request;

public class AuditLogRequestDto 
{
    public Guid? UserId { get; set; } 
    public string EntityName { get; set; } = null!; 
    public string EntityId { get; set; } = null!; 
    public string Action { get; set; } = null!; 
    public string? OldValues { get; set; } 
    public string? NewValues { get; set; } 
    public string? IpAddress { get; set; } 
    public string? UserAgent { get; set; } 
}