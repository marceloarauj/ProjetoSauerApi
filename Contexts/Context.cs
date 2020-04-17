using Microsoft.EntityFrameworkCore;
using ProjetoEngSoftware.Entity;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Contexts
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {
            
        } 
        public DbSet<Cadastro> Cadastros {get;set;}
        public DbSet<Login> Logins {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        protected override void OnModelCreating(ModelBuilder model){
            model.ApplyConfiguration(new LoginEntity());
            model.ApplyConfiguration(new EtniaEntity());
            model.ApplyConfiguration(new PacienteEntity());
            model.ApplyConfiguration(new MedicoProfessorEntity());
            model.ApplyConfiguration(new MedicoResidenteEntity());

            base.OnModelCreating(model);
        }
    }
}