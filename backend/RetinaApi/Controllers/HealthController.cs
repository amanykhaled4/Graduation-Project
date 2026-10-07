using Microsoft.AspNetCore.Mvc;

namespace RetinaApi.Controllers;

// أبسط API: بيرد إن السيرفر شغال
// العنوان: GET http://localhost:5210/api/health
[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { status = "ok", message = "RetinaApi is running", time = DateTime.Now });
    }
}
