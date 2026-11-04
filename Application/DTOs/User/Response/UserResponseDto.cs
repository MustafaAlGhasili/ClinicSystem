namespace Application.DTOs.User.Response;

public class UserResponseDto 
{
    public Guid Id { get; set; } 
    public Guid RoleId { get; set; } 
    public string Phone { get; set; } = null!; 
    public string FullName { get; set; } = null!; 
    public int Gender { get; set; } 
    public string? ProfileImageUrl { get; set; } 
    public bool IsVerified { get; set; } 
    public DateTime? LastLoginAt { get; set; } 
    public DateTime CreatedAt { get; set; } 
}