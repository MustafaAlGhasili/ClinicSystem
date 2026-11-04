namespace Application.DTOs.Specialty.Request;

public class SpecialtyRequest
{
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public decimal? BaseFee { get; set; }
    public Guid? ParentId { get; set; }
    public bool IsActive { get; set; } = true;
}