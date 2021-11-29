using Microsoft.EntityFrameworkCore;
using ToDoList.Models;
using ToDoList.Data.Calendar;

namespace ToDoList.Data
{
    public class DB : DbContext
    {
        public DB(DbContextOptions<DB> options) : base (options)
        {
           // Database.EnsureDeleted();   // Delete old database
           // Database.EnsureCreated();   // create new database
        }
        
        
        public DbSet<TodoItem> TodoItems { get; set; }

        public DbSet<DayEvent> DayEvents { get; set; }
    }
}
