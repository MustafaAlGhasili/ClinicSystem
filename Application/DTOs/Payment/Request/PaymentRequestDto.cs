namespace Application.DTOs.Payment.Request;

public class PaymentRequestDto 
{
    public Guid AppointmentId { get; set; } 
    public decimal Amount { get; set; } 
    public int PaymentMethod { get; set; }
    public string? TransactionReference { get; set; } 
    public string? Notes { get; set; } 
}