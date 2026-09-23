var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 1. Data Store (In-Memory for demonstration)
var servers = new List<ServerRecord>
{
    new(1, "192.168.1.10", "Online"),
    new(2, "192.168.1.20", "Maintenance"),
    new(3, "192.168.1.30", "Offline")
};

// 2. GET all servers (Returns JSON automatically)
app.MapGet("/api/servers", () => Results.Ok(servers));

// 3. GET server by ID using LINQ
app.MapGet("/api/servers/{id:int}", (int id) =>
{
    var server = servers.FirstOrDefault(s => s.Id == id);
    return server is not null 
        ? Results.Ok(server) 
        : Results.NotFound(new { Message = $"Server with ID {id} not found." });
});

// 4. POST to create a new server
app.MapPost("/api/servers", (CreateServerDto dto) =>
{
    int nextId = servers.Count > 0 ? servers.Max(s => s.Id) + 1 : 1;
    var newServer = new ServerRecord(nextId, dto.IpAddress, "Online");
    servers.Add(newServer);

    return Results.Created($"/api/servers/{newServer.Id}", newServer);
});

// 5. PUT to update status using record 'with' expression
app.MapPut("/api/servers/{id:int}/status", (int id, UpdateStatusDto dto) =>
{
    var index = servers.FindIndex(s => s.Id == id);
    if (index == -1) return Results.NotFound();

    // Records are immutable: create a clone with updated status and replace in list
    servers[index] = servers[index] with { Status = dto.Status };

    return Results.Ok(servers[index]);
});

app.Run();

// --- Domain Models & DTOs (Records) ---
public record ServerRecord(int Id, string IPAddress, string Status);
public record CreateServerDto(string IpAddress);
public record UpdateStatusDto(string Status);