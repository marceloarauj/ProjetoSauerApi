using Microsoft.EntityFrameworkCore;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Contexts
{
    public class LaudoContext:DbContext
    {
        public DbSet<Laudo> Laudos { get; set; }
        public LaudoContext(DbContextOptions<LaudoContext> options) :base(options)
        {
            
        }
}
}