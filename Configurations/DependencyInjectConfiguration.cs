using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Contexts;
using Microsoft.Extensions.Configuration;
using ProjetoEngSoftware.Services;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Configurations
{
    public class DependencyInjectConfiguration
    {
        public static void Registrar(IServiceCollection services, IConfiguration configuration){
            
            #region Services
            services.AddTransient<CadastroService>();
            services.AddTransient<ExameService>();
            services.AddTransient<LaudoService>();
            services.AddTransient<LoginService>();
            services.AddTransient<MedicoResidenteService>();
            services.AddTransient<MedicoService>();
            services.AddTransient<ProfessorService>();
            #endregion

            #region Repositories
            services.AddTransient<CadastroRepository>();
            services.AddTransient<ExameRepository>();
            services.AddTransient<LaudoRepository>();
            services.AddTransient<LoginRepository>();
            services.AddTransient<MedicoResidenteRepository>();
            services.AddTransient<PerfilRepository>();
            services.AddTransient<ProfessorRepository>();
            #endregion

            services.AddEntityFrameworkNpgsql().AddDbContext<Context>
                (options =>options.UseNpgsql(configuration.GetConnectionString("SauerBD")));                 
        }
    }
}