public class Server
{
    public string Status { get; set; }
    public string IpAddress { get; init; }

    public Server( string ipAddress)
    {
        Status = "Offline";
        IpAddress = ipAddress;
    }


    public void UpdateStatus(string newStatus)
    {
        Status = newStatus;
    }
    public void Reboot()
    {
        Console.WriteLine($"Rebooting server at {IpAddress}...");
        Status = "Online";
    }
}