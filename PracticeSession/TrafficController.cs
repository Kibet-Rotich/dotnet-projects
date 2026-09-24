public class TrafficController
{
    public static string EvaluateTraffic(int vehicleCount)
    {
        var roadstatus = vehicleCount switch
        {
            0=> "Empty road",
            >=1 and <=19 => "Light traffic",
            >=20 and <= 49 => "Moderate traffic",
            >= 50 => "Heavy congestion",
            _ => "Invalide count"

        };
        return roadstatus;
    }

    public static int GetAccessLevel(string role, int departmentcode)
    {
        var level = (role, departmentcode) switch
        {
            ("Admin",_) => 10,
            ("Engineer", 101) => 7,
            ("Engineer", _) => 5,
            ("Guest",_)=> 1,
            (_,_) => 0
        };
        return level;
    }
}