namespace EquiBillApi.Models;

public class Unit
{
    public int Id { get; set; }
    public string UnitNumber { get; set; } = string.Empty;
    public int OccupantsCount { get; set; } = 1;

    // Foreign Key + Navigation property (equivalent to ForeignKey(Building, on_delete=...))
    public int BuildingId { get; set; }
    public Building Building { get; set; } = null!;

    public List<Tenant> Tenants { get; set; } = [];
}