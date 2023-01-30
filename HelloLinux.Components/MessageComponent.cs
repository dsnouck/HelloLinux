namespace HelloLinux.Components;

using HelloLinux.Repositories;

public class MessageComponent: IMessageComponent
{
    private readonly IMessageRepository messageRepository;

    public MessageComponent(IMessageRepository messageRepository)
    {
        this.messageRepository = messageRepository;
    }

    public string GetMessage()
    {
        return this.messageRepository.GetMessage();
    }
}
