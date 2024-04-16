using Microsoft.EntityFrameworkCore;
using TrabalhandoComEntityFramework.Entities;

namespace TrabalhandoComEntityFramework.DataContext
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options){}

        public DbSet<Tarefa>? Tarefa { get; set; }

    }
}
