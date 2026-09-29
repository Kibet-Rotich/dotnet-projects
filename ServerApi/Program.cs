// 1. The Builder: This is where you configure the app before it starts
// (Like adding database connections, CORS, or authentication)
var builder = WebApplication.CreateBuilder(args);

// 2. The App: The actual running web server
var app = builder.Build();

// 3. The Routes: Mapping HTTP methods to logic
app.MapGet("/", () => "Welcome to your first C# Web API!");

// Returning an anonymous object. ASP.NET Core automatically serializes this to JSON.
app.MapGet("/api/health", () => 
{
    return Results.Ok(new { Status = "Healthy", Uptime = "99.9%" });
});

app.MapGet("/kibet", () => {
    return Results.Ok(new {message= "Hey kibet", success = true});
});

// A POST route extracting data from the URL path
app.MapPost("/api/greet/{name}", (string name) => 
{
    return Results.Ok(new { Message = $"Hello, {name}! Your data was received." });
});

// 4. Start listening on the port
app.Run();