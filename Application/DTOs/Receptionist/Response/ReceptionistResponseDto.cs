namespace Application.DTOs.Receptionist.Response;

public class ReceptionistResponseDto 
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string EmployeeNumber { get; set; } = null!;
    public DateTime? HiredAt { get; set; }
    public bool IsActive { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
}