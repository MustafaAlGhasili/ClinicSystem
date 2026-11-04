using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites.RoleProfile;

public class Doctor
{
    [Key]
    public Guid Id { get; set; }
    [ForeignKey("User")]
    public Guid UserId { get; set; }
    [Required]
    [MaxLength(50)]
    public string LicenseNumber { get; set; } = null!;
    public DateTime? LicenseIssuedAt { get; set; }
    public DateTime? LicenseExpiryAt { get; set; }
    [Required]
    [MaxLength(100)]
    public Specialties Specialization { get; set; } = null!;
    [MaxLength(1000)]
    public string Biography { get; set; } = null!;
    [MaxLength(255)]
    public string Address { get; set; } = null!;
    public decimal? ConsultationFee { get; set; }
    public int? YearsOfExperience { get; set; }
    public bool IsAvailable { get; set; } = true;
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public User User { get; set; } = null!;
    
    public ICollection<Appointments> Appointments { get; set; } = new List<Appointments>();
}