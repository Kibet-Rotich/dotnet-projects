namespace EquiBillApi.Models;

public enum UtilityType
{
    Water,
    Electricity
}

public class UtilityBill
{
    public int Id { get; set; }
    public UtilityType Type { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime BillingPeriod { get; set; }
    public bool IsSplit { get; set; } = false;

    // Foreign Key + Navigation property
    public int BuildingId { get; set; }
    public Building Building { get; set; } = null!;

    public List<Invoice> Invoices { get; set; } = [];
}