namespace HelloLinux.WebApi.Controllers;

using HelloLinux.Components;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMessageComponent messageComponent;

    public MessageController()
    {
        this.messageComponent = new MessageComponent();
    }

    [HttpGet]
    public string Get()
    {
        return this.messageComponent.GetMessage();
    }
}
