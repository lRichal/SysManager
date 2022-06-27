﻿using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Data.MySql
{
    public class MySqlContext
    {
        private MySqlConnection connection;
        private readonly string connectionString = "";

        public MySqlContext(IOptions<AppConnectionSettings> appsettings)
        {
            connectionString = appsettings.Value.DefaultConnection;
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }

        public MySqlConnection Connection()
        {
            connection = new MySqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
