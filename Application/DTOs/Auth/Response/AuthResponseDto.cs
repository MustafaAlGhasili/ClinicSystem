using Application.DTOs.User.Response;

namespace Application.DTOs.Auth.Response;

public class AuthResponseDto 
{
    public string AccessToken { get; set; } = string.Empty;
    public string RefreshToken { get; set; } = string.Empty; 
    public UserResponse? User { get; set; }
}