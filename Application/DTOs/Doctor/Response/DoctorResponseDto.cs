namespace Application.DTOs.Doctor.Response;

public class DoctorResponseDto 
{
    public Guid Id { get; set; } 
    public Guid UserId { get; set; } 
    public string LicenseNumber { get; set; } = null!; 
    public DateTime? LicenseIssuedAt { get; set; } 
    public DateTime? LicenseExpiryAt { get; set; } 
    public string? Biography { get; set; } 
    public string? Address { get; set; } 
    public decimal? ConsultationFee { get; set; } 
    public int? YearsOfExperience { get; set; } 
    public bool IsAvailable { get; set; } 
    public DateTime CreatedAt { get; set; } 
}