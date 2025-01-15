using Microsoft.EntityFrameworkCore;
using KanbanBoardAPI.Models;
using Task = KanbanBoardAPI.Models.Task;

namespace KanbanBoardAPI
{
    public class KanbanDbContext : DbContext
    {
        public KanbanDbContext(DbContextOptions<KanbanDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
    }
}
