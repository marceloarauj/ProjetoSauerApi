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
            services.AddSingleton<CadastroService>();
            services.AddSingleton<ExameService>();
            services.AddSingleton<LaudoService>();
            services.AddTransient<LoginService>();
            services.AddSingleton<MedicoResidenteService>();
            services.AddSingleton<MedicoService>();
            services.AddSingleton<ProfessorService>();
            #endregion

            #region Repositories
            services.AddSingleton<CadastroRepository>();
            services.AddSingleton<ExameRepository>();
            services.AddSingleton<LaudoRepository>();
            services.AddTransient<LoginRepository>();
            services.AddSingleton<MedicoResidenteRepository>();
            services.AddSingleton<PerfilRepository>();
            services.AddSingleton<ProfessorRepository>();
            #endregion
            
            #region DBContexts
            services.AddEntityFrameworkNpgsql().AddDbContext<LaudoContext>
                (options =>options.UseNpgsql(configuration.GetConnectionString("SauerBD")));
            
            services.AddEntityFrameworkNpgsql().AddDbContext<LoginContext>
                (options =>options.UseNpgsql(configuration.GetConnectionString("SauerBD")));            
            #endregion
        }
    }
}