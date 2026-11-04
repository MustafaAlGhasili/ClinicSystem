using Application.DTOs.AppointmentService.Request;
using Application.DTOs.AppointmentService.Response;
using Domain.Entities;

namespace Application.Convertors;

public static class AppointmentServiceConvertor
{
    public static AppointmentService ToEntity(this AppointmentServiceRequestDto request, Guid appointmentId)
    {
        return new AppointmentService
        {
            AppointmentId = appointmentId,
            ServiceName = request.ServiceName,
            Description = request.Description,
            UnitPrice = request.UnitPrice,
            Quantity = request.Quantity,
            TotalPrice = request.UnitPrice * request.Quantity 
        };
    }

    public static AppointmentServiceResponseDto ToResponseDto(this AppointmentService entity)
    {
        return new AppointmentServiceResponseDto
        {
            Id = entity.Id, // Inherited from BaseEntity
            AppointmentId = entity.AppointmentId,
            ServiceName = entity.ServiceName,
            Description = entity.Description,
            UnitPrice = entity.UnitPrice,
            Quantity = entity.Quantity,
            TotalPrice = entity.TotalPrice
        };
    }
}