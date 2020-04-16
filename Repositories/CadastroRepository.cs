using System;
using System.Linq;
using ProjetoEngSoftware.Contexts;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;

namespace ProjetoEngSoftware.Repositories
{
    public class CadastroRepository
    {
        public CadastroRepository(CadastroContext cadastroContext){
            this.cadastroContext = cadastroContext;
        }
        private CadastroContext cadastroContext;

        public PerfilDTO efetuarCadastro(DadosCadastroDTO dados){
            Cadastro cadastro = this.cadastroContext.Cadastros
                                    .Where(user => user.login == dados.Login).FirstOrDefault();
            
            if(cadastro != null)
                return null;
            
            Cadastro novoUsuario = new Cadastro();
            novoUsuario.login = dados.Login;
            novoUsuario.password = dados.Password;

            cadastroContext.Cadastros.Add(novoUsuario);
            cadastroContext.SaveChanges();

            return new PerfilDTO{Login = novoUsuario.login};
        }
    }
}