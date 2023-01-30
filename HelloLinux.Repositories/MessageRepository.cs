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

    public Message GetMessage()
    {
        if (this.helloLinuxContext.Messages.Count() != 1)
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
        }

        return this.helloLinuxContext.Messages.Single();
    }

    public void UpdateMessage(Message message)
    {
        this.helloLinuxContext.Messages.Update(message);
        this.helloLinuxContext.SaveChanges();
    }
}
