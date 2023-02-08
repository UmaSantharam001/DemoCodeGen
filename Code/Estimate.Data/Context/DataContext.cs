using Estimate.Data.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.Authentication;
using System.Text;

namespace Estimate.Data.Context
{
    public class DataContext : IGateway
    {
        private IConfiguration _configuration;
        private readonly string _connectionString;
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("SqlConnection");
        }
        public IDbConnection CreateConnection()
        {

            return new SqlConnection(_connectionString);
        }
    }
}
