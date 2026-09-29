namespace EquiBillApi.Models;

public class Invoice
{
    public int Id { get; set; }
    public decimal AmountDue { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsPaid { get; set; } = false;

    // Foreign Keys + Navigation properties
    public int TenantId { get; set; }
    public Tenant Tenant { get; set; } = null!;

    public int UtilityBillId { get; set; }
    public UtilityBill UtilityBill { get; set; } = null!;
}