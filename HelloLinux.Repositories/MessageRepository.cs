namespace HelloLinux.Repositories;

using HelloLinux.Database;
using HelloLinux.Models;

public class MessageRepository : IMessageRepository
{
    private readonly HelloLinuxContext helloLinuxContext;

    public MessageRepository()
    {
        this.helloLinuxContext = new HelloLinuxContext();
    }

    public string GetMessage()
    {
        if (this.helloLinuxContext.Messages.Count() == 1)
        {
            return this.helloLinuxContext.Messages.Single().Content;
        }
        else
        {
            foreach (var message in this.helloLinuxContext.Messages)
            {
                this.helloLinuxContext.Messages.Remove(message);
            }

            var newMessage = new Message
            {
                Content = "Hello, linux!",
            };
            this.helloLinuxContext.Messages.Add(newMessage);
            
            this.helloLinuxContext.SaveChanges();
            
            return newMessage.Content;
        }
    }
}
