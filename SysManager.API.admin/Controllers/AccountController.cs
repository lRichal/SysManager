

using Microsoft.AspNetCore.Mvc;
using SysManager.Application.Contracts.Users.Request;
using SysManager.Application.Helpers;
using SysManager.Application.Services;
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
        private readonly UserService userService;
        public AccountController(UserService service)
        {
            this.userService = service;
        }

        [HttpPost("create-account")]
        public async Task<IActionResult> Post([FromBody]UserPostRequest request)
        {
            Console.WriteLine("Inicio do processo");

            var response = await userService.PostAsync(request);

            return Utils.Convert(new ResultData(true));
            //return Ok ("Requisicao efetuada com sucesso");
        }

        [HttpPost("login")]
        public async Task<IActionResult> PostLogin([FromBody]UserPostRequest request)
        {
            Console.WriteLine("\r\n Inicio do processo \r\n");
            return Utils.Convert(new ResultData(false));
            //return BadRequest("Requisicao falhou");
        }
    }
}
