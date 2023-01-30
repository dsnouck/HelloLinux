namespace HelloLinux.Repositories;

using HelloLinux.Models;

public interface IMessageRepository
{
    Message GetMessage();
    
    void UpdateMessage(Message message);
}
