namespace HelloLinux.Repositories;

public class MessageRepository : IMessageRepository
{
    public string GetMessage()
    {
        return "Hello, linux!";
    }
}
