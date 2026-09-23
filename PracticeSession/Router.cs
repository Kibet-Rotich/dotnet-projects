public class Router(string  name, string ipAddress)
{
    public string Name { get; set; } = name;
    public string IPAddress{get; init; } = ipAddress;
    

    public void Ping() => Console.WriteLine($"Pinging {Name} at {IPAddress}");
}