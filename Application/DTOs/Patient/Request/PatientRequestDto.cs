namespace Application.DTOs.Patient.Request;

public class PatientRequestDto 
{
    public Guid UserId { get; set; } 
    public DateTime? DateOfBirth { get; set; } 
    public string? Address { get; set; } 
    public string? EmergencyContactName { get; set; } 
    public string? EmergencyContactPhone { get; set; } 
    public string? MedicalNotes { get; set; } 
}