using System.Reflection;
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

// var profile1 = new ServerProfile("use-east-1a","us-east",4, true);
// var profile2 = profile1 with {Hostname = "us-east-1b", CpuCores = 8};

// Console.WriteLine($"{profile1 == profile2}");
// var profile3 = new ServerProfile("use-east-1a","us-east",4, true);
// Console.WriteLine(profile1 == profile3);
// SafeCalculator.TrySquareRoot(16, out double root1);
// SafeCalculator.TrySquareRoot(-1, out double root2);

// Console.WriteLine($"root of 16 = {root1}");
// Console.WriteLine($"root of -4 = {root2}");

// SafeCalculator.TryParseAndMultiply("4", "5",out int res1);
// SafeCalculator.TryParseAndMultiply("4", "abc",out int res2);
// Console.WriteLine($"{res1}, {res2}");


// var registry = new DeviceRegistry(["tecno old","samsung a57", "iphone 17", "vivo y7 old"]);
// registry.Register("Oppo a16 old");
// Console.WriteLine(registry.PurgeDecommissioned("old"));

// var gradeBook = new StudentGradeBook();
// gradeBook.AddStudent("Amina", 92.5);
// gradeBook.AddStudent("Brian", 68.0);
// gradeBook.AddStudent("Clara", 84.0);
// gradeBook.AddStudent("David", 74.5);
// gradeBook.AddStudent("Elena", 78.5);
// gradeBook.AddStudent("Felix", 61.0);

// Console.WriteLine($"Class average: {gradeBook.GetAverageScore():F2}");
// Console.WriteLine("Honor roll:");
// foreach (var name in gradeBook.GetHonorRoll(75.0))
// {
// 	Console.WriteLine(name);
// }
// var analyzer = new LogAnalyzer();
// analyzer.LoadLogs([
// 	new LogEntry { Level = "INFO", Source = "AuthService", Message = "User signed in" },
// 	new LogEntry { Level = "WARN", Source = "ApiGateway", Message = "Request rate is elevated" },
// 	new LogEntry { Level = "ERROR", Source = "PaymentService", Message = "Payment timed out" },
// 	new LogEntry { Level = "INFO", Source = "InventoryService", Message = "Stock updated" },
// 	new LogEntry { Level = "ERROR", Source = "Database", Message = "Connection failed" },
// 	new LogEntry { Level = "WARN", Source = "AuthService", Message = "Password retry limit nearly reached" },
// 	new LogEntry { Level = "INFO", Source = "NotificationService", Message = "Email queued" },
// 	new LogEntry { Level = "ERROR", Source = "ApiGateway", Message = "Upstream service unavailable" }
// ]);

// foreach (var summary in analyzer.GetCountsPerLevel())
// {
// 	Console.WriteLine($"{summary.Key}: {summary.Value}");
// }

var billingEngine = new CloudBillingEngine("Acme Corp");
billingEngine.RecordUsage("Compute", "Premium", 100);
billingEngine.RecordUsage("Storage", "Standard", 500);
billingEngine.RecordUsage("Database", "Standard", 20);
billingEngine.RecordUsage("Compute", "Standard", 100);
billingEngine.RecordUsage("Database", "Premium", 10);

Console.WriteLine($"Total bill: {billingEngine.GenerateTotalBill():C}");
if (billingEngine.TryGetHighestCostService(out var highestCostService, out var highestCost))
{
	Console.WriteLine($"Most expensive service: {highestCostService} ({highestCost:C})");
}

