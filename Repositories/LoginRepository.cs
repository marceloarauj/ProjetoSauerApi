using System.Linq;
using ProjetoEngSoftware.Configurations;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class LoginRepository
    {
        public LoginRepository(LoginContext loginContext){
            this.loginContext = loginContext;
        }
        private LoginContext loginContext;
        public PerfilDTO efetuarLogin(LoginDTO login){
                        
            Login user = this.loginContext.Logins.Where(user => user.login == login.Login &&
                                                   user.password == login.Password).FirstOrDefault();
            
            if(user == null)
                return null;

            return new PerfilDTO{Login = user.login};            
        }
    }
}