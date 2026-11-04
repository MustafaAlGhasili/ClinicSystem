using Application.DTOs.User.Request;
using Application.DTOs.User.Response;

namespace Application.Interfaces.Services;

public interface IUserService
{
    Task<UserResponseDto?> GetByIdAsync(
        Guid id, 
        CancellationToken cancellationToken = default);

    Task<UserResponseDto?> GetByPhoneAsync(
        string phone, 
        CancellationToken cancellationToken = default);

    Task<UserResponseDto> CreateAsync(
        UserRequestDto requestDto, 
        CancellationToken cancellationToken = default);
}