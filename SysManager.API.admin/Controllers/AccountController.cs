using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using SysManager.Application.Contracts.Products.Request;

namespace SysManager.API.admin.Controllers
{   /// <summary>
    /// controladora de contas
    /// </summary>
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    class AccountController
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
            return "Login efetuado com sucesso";
        }
    }
}
