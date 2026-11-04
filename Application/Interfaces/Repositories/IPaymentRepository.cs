using Domain.Entities;

namespace Application.Interfaces.Repository;

public interface IPaymentRepository
{
    Task<Payment?> GetByIdAsync(Guid id);
    Task<Payment?> GetByTransactionReferenceAsync(string reference);
    Task<IEnumerable<Payment>> GetByAppointmentIdAsync(Guid appointmentId);
    Task AddAsync(Payment payment);
    void Update(Payment payment);
}