namespace Application.DTOs.AppointmentStatusHistory.Request;

public class AppointmentStatusHistoryRequestDto 
{
    public Guid AppointmentId { get; set; } 
    public int? PreviousStatus { get; set; } 
    public int NewStatus { get; set; } 
    public Guid? ChangedByUserId { get; set; } 
    public string? Notes { get; set; } 
}