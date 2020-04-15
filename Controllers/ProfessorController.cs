using Microsoft.AspNetCore.Mvc;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessorController:ControllerBase
    {
        [HttpGet("{idProfessor}")]
        public string obterProfessor(int idProfessor){
            return "sucesso !" + idProfessor;
        }
        [HttpPost]
        public void cadastrarProfessor(){

        }
        [HttpPut]
        public void alterarProfessor(){

        }
    }
}