namespace HelloLinux.Components;

using HelloLinux.Repositories;

public class MessageComponent: IMessageComponent
{
    private readonly IMessageRepository messageRepository;

    public MessageComponent(IMessageRepository messageRepository)
    {
        this.messageRepository = messageRepository;
    }

    public string GetMessageContent()
    {
        return this.messageRepository.GetMessage().Content;
    }

    public void UpdateMessageContent(string content)
    {
        var message = this.messageRepository.GetMessage();
        message.Content = content;
        this.messageRepository.UpdateMessage(message);
    }
}
