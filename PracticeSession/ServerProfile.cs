public record ServerProfile(string hostname, string region, int cores, bool isactive)
{
    public string Hostname = hostname;
    public string Region = region;
    public int CpuCores = cores;
    public bool IsActive = isactive;
    

}
