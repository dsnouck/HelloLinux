namespace HelloLinux.WebApi.Controllers;

using HelloLinux.Components;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly IMessageComponent messageComponent;

    public MessageController(IMessageComponent messageComponent)
    {
        this.messageComponent = messageComponent;
    }

    [HttpGet]
    public string Get()
    {
        return this.messageComponent.GetMessageContent();
    }

    [HttpPut]
    public void Put(string content)
    {
        this.messageComponent.UpdateMessageContent(content);
    }
}
