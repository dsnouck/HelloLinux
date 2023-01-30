namespace HelloLinux.Components;

public class MessageComponent: IMessageComponent
{
    public string GetMessage()
    {
        return "Hello, linux!";
    }
}
