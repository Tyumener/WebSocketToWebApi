using Microsoft.EntityFrameworkCore;

namespace Websockettorest.DataAccess
{
    public class Context : DbContext
    {
        public DbSet<Event> Events { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Integrated Security=true");
        }
    }
}
