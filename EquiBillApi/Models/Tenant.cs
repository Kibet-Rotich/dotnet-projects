namespace EquiBillApi.Models;

public class Tenant
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;

    // Foreign Key + Navigation property
    public int UnitId { get; set; }
    public Unit Unit { get; set; } = null!;

    public List<Invoice> Invoices { get; set; } = [];
}