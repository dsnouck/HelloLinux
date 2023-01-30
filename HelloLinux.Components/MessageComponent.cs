namespace HelloLinux.Components;

using HelloLinux.Repositories;

public class MessageComponent: IMessageComponent
{
    private readonly IMessageRepository messageRepository;

    public MessageComponent()
    {
        this.messageRepository = new MessageRepository();
    }

    public string GetMessage()
    {
        return this.messageRepository.GetMessage();
    }
}
