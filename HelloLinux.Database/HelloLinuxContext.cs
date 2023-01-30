namespace HelloLinux.Database;

using HelloLinux.Models;
using Microsoft.EntityFrameworkCore;

public class HelloLinuxContext : DbContext
{
    public DbSet<Message> Messages => this.Set<Message>();

    public string DatabasePath { get; }

    public HelloLinuxContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DatabasePath = System.IO.Path.Join(path, "message.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DatabasePath}");
}
