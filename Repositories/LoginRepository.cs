using System.Linq;
using ProjetoEngSoftware.Configurations;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class LoginRepository
    {
        public LoginRepository(Context loginContext){
            this.loginContext = loginContext;
        }
        private Context loginContext;
        public PerfilDTO efetuarLogin(LoginDTO login){
                        
            Login user = this.loginContext.Logins.Where(user => user.UserLogin == login.Login &&
                                                   user.Password == login.Password).FirstOrDefault();
            
            if(user == null)
                return null;

            return new PerfilDTO{Login = user.UserLogin};            
        }
    }
}