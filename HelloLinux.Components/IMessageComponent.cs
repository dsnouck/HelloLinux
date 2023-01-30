namespace HelloLinux.Components;

public interface IMessageComponent
{
    string GetMessageContent();
    
    void UpdateMessageContent(string content);
}
