using Microsoft.EntityFrameworkCore;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Contexts
{
    public class LoginContext:DbContext
    {
        public DbSet<Login> Laudos { get; set; }
        public LoginContext(DbContextOptions<LoginContext> options) :base(options)
        {
            
        } 
    }
}