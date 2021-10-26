using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_Data.Internal.DataAccess
{
    internal class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;
        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }
        public string ConnectionStringName { get; set; } = "TaskZ_Data";
        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString(ConnectionStringName));
            }
        }
        public async Task<List<T>> LoadDataBySql<T>(string sql)
        {
            using (Connection)
            {
                var rows = await Connection.QueryAsync<T>(sql);
                return rows.ToList();
            }
        }
        public void SaveDataBySql(string sql)
        {
            using (Connection)
            {
                Connection.Execute(sql);
            }
        }
    }
}
