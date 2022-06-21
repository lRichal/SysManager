using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Contracts.Users.Request
{   /// <summary>
    /// classe "Contracts" responsavel para
    /// cadastrar um novo usuario
    /// </summary>
    public class UserPostRequest
    {
        /// <summary>
        /// classe referente ao nome do usuario
        /// </summary>
      public string UserName { get; set; }
        /// <summary>
        /// classe referente ao email do usuario
        /// </summary>
      public string Email { get; set; }
        /// <summary>
        /// classe referente a senha do usuario
        /// </summary>
      public string Password { get; set; }

    }
}
