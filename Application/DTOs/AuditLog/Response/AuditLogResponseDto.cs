namespace Application.DTOs.AuditLog.Response;

public class AuditLogResponse 
{
    public Guid Id { get; set; } 
    public Guid? UserId { get; set; } 
    public string EntityName { get; set; } = null!; 
    public string EntityId { get; set; } = null!; 
    public string Action { get; set; } = null!; 
    public string? OldValues { get; set; } 
    public string? NewValues { get; set; } 
    public string? IpAddress { get; set; } 
    public string? UserAgent { get; set; } 
    public DateTime CreatedAt { get; set; } 
}