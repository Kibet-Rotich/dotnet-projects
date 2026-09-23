List<string?> strings = new List<string?> { "Online", "Offline", null, "Maintenance" };

// for(int i = strings.Count - 1; i >= 0; i--)
// {
//     if (strings[i] == null)
//     {
//         strings.RemoveAt(i);
//     }
// }

// foreach(var status in strings)
// {
//     string statusMessage = status switch
//     {
//         "Online" => "System is operational.",
//         "Offline" => "System is down.",
//         "Maintenance" => "System is under maintenance.",
//         _ => "Unknown status."
//     };
//     Console.WriteLine(statusMessage);
// }

// void ForceOnline(ref string? status)
// {
//     status = "Online";
// }

// string? brokenServer = "Offline";
// ForceOnline(ref brokenServer);
// Console.WriteLine($"Forced status: {brokenServer}");

// var statusMessages = strings
//     .Where(s => s != null)
//     .Select(s => s switch
//     {
//         "Online" => "System is operational.",
//         "Offline" => "System is down.",
//         "Maintenance" => "System is under maintenance.",
//         _ => "Unknown status."
//     })
//     .ToList();

// foreach(var message in statusMessages)
// {
//     Console.WriteLine(message);
// }





// var server1 = new Server("192.168.1.100")
// {
//     Status = "Maintenance"
// };


int[] numbers = new int[4];
numbers[0] = 10;
numbers[1] = 20;

string[] protocols = ["HTTP", "HTTPS", "FTP", "SSH"];

Console.WriteLine($" Array length: {numbers.Length}, Protocols length: {protocols.Length}");

var list = new List<int>();
for(int i = 0; i < 20; i++)
{
    list.Add(i);
    Console.WriteLine($"Added {i}, List count: {list.Count}, capacity: {list.Capacity}");
}

list.ToArray();
//list[20] = 100; // This will throw an exception because the index is out of range
Console.WriteLine($"capacity after ToArray: {list.Capacity}, count: {list.Count}");