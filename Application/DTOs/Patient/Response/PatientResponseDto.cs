namespace Application.DTOs.Patient.Response;

public class PatientResponseDto 
{
    public Guid Id { get; set; } //[cite: 1]
    public Guid UserId { get; set; } //[cite: 1]
    public DateTime? DateOfBirth { get; set; } //[cite: 1]
    public string? Address { get; set; } //[cite: 1]
    public string? EmergencyContactName { get; set; } //[cite: 1]
    public string? EmergencyContactPhone { get; set; } //[cite: 1]
    public string? MedicalNotes { get; set; } //[cite: 1]
    public DateTime CreatedAt { get; set; } //[cite: 1]
}