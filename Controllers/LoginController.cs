using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.DTO;
using ProjetoEngSoftware.Models;
using ProjetoEngSoftware.Services;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController:ControllerBase
    {
        private LoginService loginService;
        public LoginController(LoginService loginService){
            this.loginService = loginService;
        }
        [HttpPost]
        public ActionResult<Perfil> efetuarLogin([FromBody] LoginDTO login){
            var retorno = loginService.efetuarLogin(login);

            if(retorno == null)      
                return BadRequest("Login ou senha incorretos");

            return Ok(retorno);
        }
    }
}