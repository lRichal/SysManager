

using Microsoft.AspNetCore.Mvc;
using SysManager.Application.Contracts.Users.Request;
using SysManager.Application.Helpers;
using System;
using System.Threading.Tasks;

namespace SysManager.API.admin.Controllers
{   /// <summary>
    /// controladora de contas
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AccountController : ControllerBase
    {
        public AccountController()
        {
        }

        [HttpPost("create-account")]
        public async Task<IActionResult> Post([FromBody]UserPostRequest request)
        {
            Console.WriteLine("Inicio do processo");
            return Utils.Convert(new ResultData(true));
            //return Ok ("Requisicao efetuada com sucesso");
        }

        [HttpPost("login")]
        public async Task<IActionResult> PostLogin([FromBody]UserPostRequest request)
        {
            Console.WriteLine("Inicio do processo 2");
            return Utils.Convert(new ResultData(false));
            //return BadRequest("Requisicao falhou");
        }
    }
}
