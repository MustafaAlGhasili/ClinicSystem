namespace Application.DTOs.User.Request;

public class UserRequestDto 
{
    public Guid RoleId { get; set; } 
    public string Phone { get; set; } = null!; 
    public string FullName { get; set; } = null!; 
    public string Password { get; set; } = null!; 
    public int Gender { get; set; } 
    public string? ProfileImageUrl { get; set; } 
}