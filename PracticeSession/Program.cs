using System.Security.Cryptography;

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


// int[] numbers = new int[4];
// numbers[0] = 10;
// numbers[1] = 20;

// string[] protocols = ["HTTP", "HTTPS", "FTP", "SSH"];

// Console.WriteLine($" Array length: {numbers.Length}, Protocols length: {protocols.Length}");

// var list = new List<int>();
// for(int i = 0; i < 20; i++)
// {
//     list.Add(i);
//     Console.WriteLine($"Added {i}, List count: {list.Count}, capacity: {list.Capacity}");
// }

// list.ToArray();
// //list[20] = 100; // This will throw an exception because the index is out of range
// Console.WriteLine($"capacity after ToArray: {list.Capacity}, count: {list.Count}");

// bool TryDivide(double numerator, double denominator, out double results)
// {
//     if(denominator == 0)
//     {
//         results = 0;
//         return false;
//     }
//     else
//     {
//         results = numerator/denominator;
//         return true;
//     }
// }


// bool r1 = TryDivide(34,0,out double num1);

// bool r2 = TryDivide(34,2,out double num2);
// Console.WriteLine($"Valid = {num2}, invalid={num1}");
// Console.WriteLine($"Valid = {r2}, invalid={r1}");

// var router = new Router("Core-Gateway","10.0.0.1");
// router.Ping();

// var account = new BankAccount("123456","Kibet");
// account.Deposit(10000);
// Console.WriteLine(account.TryWithdraw(4000,out decimal newbalance));
// Console.WriteLine(newbalance);

// var rectangle = new Rectangle(5,10);
// Console.WriteLine($"Perimeter: {rectangle.Perimeter}, Area: {rectangle.GetArea()}");

// var tem = new Thermometer(25);
// try
// {
//     var tem1 = new Thermometer(-300);
// }
// catch(ArgumentOutOfRangeException)
// {
//     Console.WriteLine("temperature out ofexpected range");
    
// }
// Console.WriteLine($"{tem.Fahrenheit}");

var profile1 = new ServerProfile("use-east-1a","us-east",4, true);
var profile2 = profile1 with {Hostname = "us-east-1b", CpuCores = 8};

Console.WriteLine($"{profile1 == profile2}");
var profile3 = new ServerProfile("use-east-1a","us-east",4, true);
Console.WriteLine(profile1 == profile3);