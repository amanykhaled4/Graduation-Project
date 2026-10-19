using Microsoft.AspNetCore.Mvc;

namespace RetinaApi.Controllers;

[ApiController]
[Route("api/status")]
public class StatusController : ControllerBase
{
    [HttpGet]
    public string GetStatus()
    {
        return "RetinaAI server is running";
    }
}
