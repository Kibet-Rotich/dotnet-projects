namespace EquiBillApi.Models;

public class Building
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;

    // Navigation properties: 1-to-Many
    public List<Unit> Units { get; set; } = [];
    public List<UtilityBill> UtilityBills { get; set; } = [];
}