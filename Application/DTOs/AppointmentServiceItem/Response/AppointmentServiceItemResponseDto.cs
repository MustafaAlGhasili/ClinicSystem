namespace Application.DTOs.AppointmentServiceItem.Response;

public class AppointmentServiceResponseDto
{
    public Guid Id { get; set; }
    public Guid AppointmentId { get; set; }
    public string ServiceName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
}