using ProjetoEngSoftware.Configurations;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class LoginService
    {
        
        private LoginRepository loginRepository;
        public LoginService(LoginRepository loginRepository){
            this.loginRepository = loginRepository;
        }
        public PerfilDTO efetuarLogin(LoginDTO login){
            
            login.Password = EncryptConfiguration.EncryptPassword(login.Password);
            PerfilDTO user = loginRepository.efetuarLogin(login);
            return user;
        }
        
    }
}