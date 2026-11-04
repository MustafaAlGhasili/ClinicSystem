using System.ComponentModel.DataAnnotations;
using Domain.common;

namespace Domain.Entities;

public class AppointmentService : BaseEntity
{
    public Guid AppointmentId { get; set; }

    [Required]
    [MaxLength(150)]
    public string ServiceName { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? Description { get; set; }

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; } = 1;

    public decimal TotalPrice { get; set; }

    public Appointment Appointment { get; set; } = null!;
}