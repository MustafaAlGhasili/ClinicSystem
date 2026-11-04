namespace Application.DTOs.WorkingHours.Response;

public class WorkingHoursResponseDto 
{
    public Guid Id { get; set; } 
    public Guid DoctorId { get; set; } 
    public DayOfWeek DayOfWeek { get; set; } 
    public TimeOnly StartTime { get; set; } 
    public TimeOnly EndTime { get; set; } 
    public bool IsDayOff { get; set; } 
    public DateTime CreatedAt { get; set; } 
}