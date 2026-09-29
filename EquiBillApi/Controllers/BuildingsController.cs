using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EquiBillApi.Data;
using EquiBillApi.Models;
using EquiBillApi.DTOs;

namespace EquiBillApi.Controllers;

[ApiController]
[Route("api/[controller]")] // This makes the route: /api/buildings
public class BuildingsController : ControllerBase
{
    private readonly EquiBillDbContext _context;

    // Dependency Injection: ASP.NET automatically provides the database context here
    public BuildingsController(EquiBillDbContext context)
    {
        _context = context;
    }

    // POST: api/buildings
    [HttpPost]
    public async Task CreateBuilding([FromBody] BuildingCreateDto dto)
    {
        // Map DTO to the Entity Framework Model
        var building = new Building
        {
            Name = dto.Name,
            Address = dto.Address
        };

        _context.Buildings.Add(building);
        await _context.SaveChangesAsync();

        // Returns a 201 Created status code, with the new object and a link to get it
        return CreatedAtAction(nameof(GetBuilding), new { id = building.Id }, building);
    }

    // GET: api/buildings/5
    [HttpGet("{id}")]
    public async Task GetBuilding(int id)
    {
        var building = await _context.Buildings.FindAsync(id);
        
        if (building == null) return NotFound(); // Returns 404
        
        return Ok(building); // Returns 200 with the JSON data
    }

    // GET: api/buildings
    [HttpGet]
    public async Task GetAllBuildings()
    {
        var buildings = await _context.Buildings.ToListAsync();
        return Ok(buildings);
    }
}