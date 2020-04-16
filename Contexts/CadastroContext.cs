using Microsoft.EntityFrameworkCore;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Contexts
{
    public class CadastroContext:DbContext{
        public DbSet<Cadastro> Cadastros { get; set; }
        public CadastroContext(DbContextOptions<CadastroContext> options) :base(options)
        {
            
        }
    }
}