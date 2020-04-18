using System;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class CadastroRepository
    {
        public CadastroRepository(Context cadastroContext){
            this.cadastroContext = cadastroContext;
        }
        private Context cadastroContext;

        public PerfilDTO efetuarCadastro(DadosCadastroDTO dados){
            Login cadastro = this.cadastroContext.Logins
                                    .Where(user => user.UserLogin == dados.Login).FirstOrDefault();
            
            if(cadastro != null)
                return null;
            
            Login novoUsuario = new Login();
            novoUsuario.UserLogin = dados.Login;
            novoUsuario.Password = dados.Password;

            cadastroContext.Logins.Add(novoUsuario);
            cadastroContext.SaveChanges();

            return new PerfilDTO{Login = novoUsuario.UserLogin};
        }
    }
}