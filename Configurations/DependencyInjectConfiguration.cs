using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoEngSoftware.Contexts;
using Microsoft.Extensions.Configuration;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Configurations
{
    public class DependencyInjectConfiguration
    {
        public static void Registrar(IServiceCollection services, IConfiguration configuration){
            //Services
            services.AddSingleton<CadastroService>();
            services.AddSingleton<ExameService>();
            services.AddSingleton<LaudoService>();
            services.AddSingleton<LoginService>();
            services.AddSingleton<MedicoResidenteService>();
            services.AddSingleton<MedicoService>();
            services.AddSingleton<ProfessorService>();

            //DBContexts
            services.AddEntityFrameworkNpgsql().AddDbContext<LaudoContext>
                (options =>options.UseNpgsql(configuration.GetConnectionString("SauerBD")));
        }
    }
}