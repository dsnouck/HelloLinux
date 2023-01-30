namespace HelloLinux.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    [HttpGet]
    public string Get()
    {
        return "Hello, linux!";
    }
}
