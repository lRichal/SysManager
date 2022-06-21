

using Microsoft.AspNetCore.Mvc;
using SysManager.Application.Contracts.Users.Request;
using System.Threading.Tasks;

namespace SysManager.API.admin.Controllers
{   /// <summary>
    /// controladora de contas
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AccountController
    {
        public AccountController()
        {
         
        }

        [HttpPost("create-account")]
        public async Task<string> Post(UserPostRequest request)
        {
            return "Requisicao efetuada com sucesso";
        }

        [HttpPost("login")]
        public async Task<string> PostLogin(string obj)
        {
            return "Requisicao efetuada com sucesso";
        }
    }
}
