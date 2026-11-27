# dotnet-projects

C# / .NET 8 practice projects and small APIs, from fundamentals up to an EF Core web API.

| Folder | What's in it |
|---|---|
| `PracticeSession/` | Fundamentals recap: classes, encapsulation, collections, switch/pattern matching, exceptions (bank account, gradebook, inventory, log analyzer, traffic controller, cloud billing engine) |
| `PracticeTwo/` | Abstract classes and static classes: `BankAccount` hierarchy, `CurrencyConverter` |
| `nov5/` | Constructors, object initializers, inheritance (`Shape`, `Vehicle` → `Car` / `Motorcycle` / `Truck`) |
| `Ex07/` | Exercise 7 scaffold |
| `ServerApi/` | First minimal API: `MapGet` / `MapPost` routes |
| `EquiBillApi/` | Property and utility-bill splitting API: ASP.NET Core controllers, DTOs, EF Core + SQLite (buildings, units, tenants, utility bills, invoices) |

## Running a project

```bash
cd <ProjectFolder>
dotnet run
```

For the APIs, Swagger is available at `/swagger` in development.

For EquiBillApi, create the database first:

```bash
cd EquiBillApi
dotnet ef database update
```
