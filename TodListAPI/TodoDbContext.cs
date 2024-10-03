using Microsoft.EntityFrameworkCore;
using Models;
namespace TodListAPI;
public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options)
        : base(options) { }

    public DbSet<TodoItem> TodoItems {get; set;}
}