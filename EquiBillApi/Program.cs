using EquiBillApi.Data;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// ====================================================
// PHASE 1: DEPENDENCY INJECTION (The "Services" Container)
// ====================================================

// 1. Tell the app we are using Controllers (routing)
builder.Services.AddControllers();

// 2. We will register our database and custom services here later...
// e.g., builder.Services.AddScoped<IBillSplitter, BillSplitterService>();
builder.Services.AddDbContext<EquiBillDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
    
var app = builder.Build();

// ====================================================
// PHASE 2: THE HTTP PIPELINE (Middleware)
// ====================================================

// 1. Redirect HTTP traffic to HTTPS for security
app.UseHttpsRedirection();

// 2. Enable authorization (checking JWT tokens later)
app.UseAuthorization();

// 3. Map the URLs to the Controllers automatically
app.MapControllers();

// 4. Start the server!
app.Run();