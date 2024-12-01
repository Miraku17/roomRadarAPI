// using Microsoft.AspNetCore.Mvc;
// using roomRadarApi.Common;
// using BCrypt.Net;

// [ApiController]
// public class UsersController : BaseApiController
// {
//     [HttpPost]
//     public async Task<IActionResult> CreateUser([FromBody] User user)
//     {
//         if (user == null)
//             return BadRequest("User data is required");

//         if (string.IsNullOrEmpty(user.Email) || string.IsNullOrEmpty(user.Password))
//             return BadRequest("Email and password are required");

//         // Hash the password before saving
//         user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password);

//         // TODO: Add validation for Email format
//         // TODO: Add validation for UserType (should be either "Landlord" or "Tenant")
//         // TODO: Add check for existing email to prevent duplicates
//         // TODO: Add your database logic here
//         // await _dbContext.Users.AddAsync(user);
//         // await _dbContext.SaveChangesAsync();

//         // Don't send the hashed password back in the response
        
//         return Created($"/api/v1/users/{user.Id}", user);
//     }

//     [HttpGet("test")]
//     public IActionResult Test()
//     {
//         return Ok("API is working");
//     }
// }