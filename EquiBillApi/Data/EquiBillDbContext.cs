using Microsoft.EntityFrameworkCore;
using EquiBillApi.Models;

namespace EquiBillApi.Data;

public class EquiBillDbContext : DbContext
{
    public EquiBillDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet <Building> Buildings => Set<Building>();
    public DbSet <Unit> Units => Set<Unit> ();
    public DbSet <Tenant> Tenants => Set<Tenant>();
    public DbSet <UtilityBill> UtilityBills => Set<UtilityBill>();
    public DbSet <Invoice> Invoices => Set<Invoice>();
}