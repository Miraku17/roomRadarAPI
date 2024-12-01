using Microsoft.AspNetCore.Mvc;

namespace roomRadarApi.Common
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public abstract class BaseApiController : ControllerBase
    {
        // You can add common properties or methods here
        // For example:
        protected IActionResult Success(object data = null) 
        {
            return Ok(data);
        }

        protected IActionResult Error(string message) 
        {
            return BadRequest(new { error = message });
        }
    }
}