public record  ResourceUsage(string ServiceName, string Tier , double UnitsConsumed);

public class CloudBillingEngine(string clientname)
{
    public string ClientName{get;} = clientname;

    private List<ResourceUsage> _usages = new();
    public void RecordUsage(string service, string tier, double units)
    {
        if(units>0){
            ResourceUsage usage = new ResourceUsage( service, tier, units);
            _usages.Add(usage);
        }
    }

    public decimal CalculateRate(string service, string tier)
    {
        decimal rate = (service, tier) switch
        {
            ("Compute","Standard") => 0.05m,
            ("Compute", "Premium") => 0.12m,
            ("Storage", _) => 0.02m,
            ("Database","Standard") => 0.15m,
            ("Database", "Premium") => 0.30m,
            _ => 0.01m
        };
        return rate;
    }
    public decimal GenerateTotalBill()
    {
        return _usages.Sum(x => (decimal)x.UnitsConsumed * CalculateRate(x.ServiceName, x.Tier));
    }

    public bool TryGetHighestCostService(out string serviceName, out decimal cost)
    {
        var top = _usages
            .GroupBy(usage => usage.ServiceName)
            .Select(group => new
            {
                ServiceName = group.Key,
                Cost = group.Sum(usage => (decimal)usage.UnitsConsumed * CalculateRate(usage.ServiceName, usage.Tier))
            })
            .OrderByDescending(service => service.Cost)
            .FirstOrDefault();

        if(top is null)
        {
            serviceName = string.Empty;
            cost = 0;
            return false;
        }

        serviceName = top.ServiceName;
        cost = top.Cost;
        return true;
    }
}