using System.ComponentModel.DataAnnotations;
using Domain.common;
using Domain.Entites;

namespace Domain.Entities;

public class Specialty : BaseEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public bool IsActive { get; set; } = true;

    // Navigation Properties
    public ICollection<DoctorSpecialty> DoctorSpecialties { get; set; }
        = new List<DoctorSpecialty>();
}