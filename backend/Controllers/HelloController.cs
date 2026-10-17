using Microsoft.AspNetCore.Mvc;

namespace RetinaApi.Controllers;

[ApiController]
[Route("hello")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public string SayHello()
    {
        return "Hello from Amany's server!";
    }
}
