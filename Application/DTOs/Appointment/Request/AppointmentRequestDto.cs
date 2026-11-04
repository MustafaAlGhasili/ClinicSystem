namespace Application.DTOs.Appointment.Request;

public class AppointmentRequestDTO
{
    public Guid PatientId { get; set; } 
    public Guid DoctorId { get; set; } 
    public DateTime StartAt { get; set; } 
    public DateTime EndAt { get; set; } 
    public string? Notes { get; set; } 
    public decimal TotalPrice { get; set; } 
    public Guid? CreatedByUserId { get; set; } 
}