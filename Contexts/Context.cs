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
        public DbSet<Login> Logins {get;set;}
        public DbSet<Paciente> Pacientes {get;set;}
        public DbSet<Exame> Exames {get;set;}
        public DbSet<Etnia> Etnias {get;set;}
        public DbSet<Medico> Medicos {get;set;}
        public DbSet<MedicoProfessor> Professores {get;set;}
        public DbSet<MedicoResidente> Residentes {get;set;}
        public DbSet<PedidoExame> PedidoExames {get;set;}
        public DbSet<Laudo> Laudos {get;set;}
        protected override void OnModelCreating(ModelBuilder model){
            model.ApplyConfiguration(new LoginEntity());
            model.ApplyConfiguration(new ExameEntity());
            model.ApplyConfiguration(new EtniaEntity());
            model.ApplyConfiguration(new MedicoProfessorEntity());
            model.ApplyConfiguration(new MedicoResidenteEntity());
            model.ApplyConfiguration(new PacienteEntity());
            model.ApplyConfiguration(new MedicoEntity());
            model.ApplyConfiguration(new PedidoExameEntity());
            model.ApplyConfiguration(new LaudoEntity());

            base.OnModelCreating(model);
        }
    }
}