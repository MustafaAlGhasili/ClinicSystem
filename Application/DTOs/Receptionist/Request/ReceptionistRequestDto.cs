namespace Application.DTOs.Receptionist.Request;

public class ReceptionistRequestDto 
{
    public Guid UserId { get; set; }
    public string EmployeeNumber { get; set; } = null!;
    public DateTime? HiredAt { get; set; }
    public bool IsActive { get; set; } = true;
    public string? Notes { get; set; }
}