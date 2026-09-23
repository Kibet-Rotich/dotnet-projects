public class NetworkDevice
{
    private int _rebootCount;
    public string Hostname{get;set;}
    public string MacAddress{ get; private set; }

    public string Model {get; init;}

    public NetworkDevice(string hostname, string macAddress, string model)
    {
        Hostname = hostname;
        MacAddress = macAddress;
        Model = model;
        _rebootCount = 0;
    }    

    public void Reboot()
    {
        _rebootCount++;
        Console.WriteLine($"{Hostname} ({Model}) is rebooting. Total reboots: {_rebootCount}");
    }
}