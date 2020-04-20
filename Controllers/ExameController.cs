using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoEngSoftware.DTO;

namespace ProjetoEngSoftware.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExameController:ControllerBase
    {
        [Authorize(Roles = "Medico,Professor,Residente")]   
        [HttpPost("criar")]
        public ActionResult<string> criarPedidoExame([FromBody]PedidoExameDTO exame){
            

            return Ok();
        }
    }
}