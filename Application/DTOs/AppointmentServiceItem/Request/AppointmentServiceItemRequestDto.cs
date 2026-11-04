namespace Application.DTOs.AppointmentServiceItem.Request;

public class AppointmentServiceRequestDto
{
    public string ServiceName { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal UnitPrice { get; set; }
    public int Quantity { get; set; } = 1;
}