using System.ComponentModel.DataAnnotations;
using Domain.common;
using Domain.Entites.RoleProfile;
using Domain.Enums;

namespace Domain.Entites;

public class User : BaseEntity
{
    public Guid RoleId { get; set; }

    [Required]
    [MaxLength(255)]
    public string PasswordHash { get; set; } = null!;

    [Required]
    [MaxLength(9)]
    public string Phone { get; set; } = null!;

    [Required]
    [MaxLength(100)]
    public string FullName { get; set; } = null!;

    public Gender Gender { get; set; }

    [MaxLength(500)]
    public string? ProfileImageUrl { get; set; }

    public bool IsVerified { get; set; }

    public DateTime? LastLoginAt { get; set; }
    
    public Role Role { get; set; } = null!;

    public Doctor? DoctorProfile { get; set; }

    public Patient? PatientProfile { get; set; }
}