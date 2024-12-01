using Microsoft.AspNetCore.Mvc;
using roomRadarApi.Common;
using BCrypt.Net;
using roomRadarApi.Data;
using Microsoft.EntityFrameworkCore;

[ApiController]
[Route("api/v1/auth")]  // Add the route attribute
public class AuthController : BaseApiController
{
    private readonly AppDbContext _context;

    // Add constructor to inject DbContext
    public AuthController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] User user)
    {
        if (user == null)
            return BadRequest("User data is required");

        if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
            return BadRequest("Email and password are required");

        // Hash the password before saving
        user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

        // Add to database
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();

        return Created($"/api/v1/users/{user.Id}", user);
    }

    [HttpGet("test-db")]
    public async Task<IActionResult> TestConnection()
    {
        try
        {
            await _context.Database.CanConnectAsync();
            return Ok("Database connection successful!");
        }
        catch (Exception ex)
        {
            return BadRequest($"Connection failed: {ex.Message}");
        }
    }
}