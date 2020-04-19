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
            
            switch(dados.Medico.Tipo){

                case 0:return cadastroRepository.efetuarCadastroMedico(dados);

                case 1:return cadastroRepository.efetuarCadastroResidente(dados);             

                case 2:return cadastroRepository.efetuarCadastroProfessor(dados);
            }
            
            return null;
        }
    }
}