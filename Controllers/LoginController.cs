using System;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.Configurations;
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
        public ActionResult efetuarLogin([FromBody] LoginDTO login){
            
            PerfilDTO perfil = loginService.efetuarLogin(login);

            if(perfil == null)      
                return BadRequest("Login ou senha incorretos");

            string token = "Bearer "+ TokenConfiguration.GerarToken(perfil);

            return Ok(new {data = perfil, accessToken = token});
        }
    }
}