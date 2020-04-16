using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Repositories;

namespace ProjetoEngSoftware.Services
{
    public class CadastroService
    {
        public CadastroService (CadastroRepository cadastroRepository){
            this.cadastroRepository = cadastroRepository;
        }
        private CadastroRepository cadastroRepository;
        public PerfilDTO efetuarCadastro(DadosCadastroDTO dados){

            return cadastroRepository.efetuarCadastro(dados);
        }
    }
}