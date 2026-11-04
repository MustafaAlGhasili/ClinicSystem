namespace Application.DTOs.WorkingHours.Request;

public class WorkingHoursRequestDto 
{
    public Guid DoctorId { get; set; } 
    public DayOfWeek DayOfWeek { get; set; } 
    public TimeOnly StartTime { get; set; } 
    public TimeOnly EndTime { get; set; } 
    public bool IsDayOff { get; set; } 
}