namespace Application.DTOs.AppointmentStatusHistory.Response;

public class AppointmentStatusHistoryResponseDto 
{
    public Guid Id { get; set; } 
    public Guid AppointmentId { get; set; } 
    public int? PreviousStatus { get; set; } 
    public int NewStatus { get; set; } 
    public Guid? ChangedByUserId { get; set; } 
    public string? Notes { get; set; } 
    public DateTime CreatedAt { get; set; } 
}