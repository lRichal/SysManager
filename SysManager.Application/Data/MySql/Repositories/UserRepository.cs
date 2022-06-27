using SysManager.Application.Data.MySql.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SysManager.Application.Data.MySql.Repositories
{
    /// <summary>
    /// Classe responsavel por se comunincar com o banco de dados
    /// enviando os comandos para criar, alterar, consultar e excluir registros
    /// </summary>
    public class UserRepository
    {
        private readonly MySqlContext context;
        public UserRepository(MySqlContext context)
        {
            this.context = context;
        }

        public async Task<UserEntity> CreateUser(UserEntity entity)
        {
            var _sql = @$"INSERT INTO user(id, userName, email, password, active)
                                     VALUE(@id, @userName, @email, @password, @active)";

            return new UserEntity();
        }

        public async Task<UserEntity> UpdateUser(Guid id, string password)
        {
            var _sql = @$"UPDATE user set password = {password} where id = '{id}'";

            return new UserEntity();
        }

        public async Task<UserEntity> GetUserByEmail(string email)
        {
            var _sql = @$"SELECT id, userName, email, password, active from user where email =  '{email}'";

            return new UserEntity();
        }

        public async Task<UserEntity> InactiveUser(Guid id)
        {
            var _sql = $"UPDATE user set active = false where id = '{id}'";

            return new UserEntity();
        }


    }
}
