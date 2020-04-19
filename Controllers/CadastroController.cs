using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.Configurations;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CadastroController:ControllerBase
    {
        public CadastroController(CadastroService cadastroService){
            this.cadastroService = cadastroService;
        }
        private CadastroService cadastroService;

        [HttpPost]
        public ActionResult efetuarCadastro(DadosCadastroDTO dados){
            dados.Password = EncryptConfiguration.EncryptPassword(dados.Password);

            PerfilDTO perfil = cadastroService.efetuarCadastro(dados);

            if(perfil == null)
                return BadRequest("Login de usuário já existente");

            return Ok(perfil);
        }
    }
}