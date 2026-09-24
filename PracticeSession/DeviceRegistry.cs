public class DeviceRegistry
{
    public List<string> Devices = [];

    public DeviceRegistry(IEnumerable<string>? initialDevices = null, int capacity = 10)
    {
        if (initialDevices != null)
        {
            Devices = new List<string>(initialDevices);
        }
        else
        {
            Devices = new List<string>(capacity);
        }
    }
   
    public void Register(string deviceName) => Devices.Add(deviceName);
    
    public int PurgeDecommissioned(string keyword)

    {
        int removed = 0;
        for(int i = Devices.Count-1; i >= 0; i--)
        {
            if(Devices[i].Contains(keyword, StringComparison.OrdinalIgnoreCase))
            {
                Devices.RemoveAt(i);
                removed++;

            }
        }
        return removed;
    }

}