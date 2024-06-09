using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet("TestMessage")]
    public string GetMessage()
    {
        return "Hello from the ASP.NET MVC Controller!";
    }
}
