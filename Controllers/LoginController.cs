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
        public ActionResult<Perfil> efetuarLogin([FromBody] LoginDTO login){

            bool resultado = loginService.efetuarLogin(login);

            return Ok();
        }
    }
}