using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_DataAccess.Utilities
{
    public static class DatabaseHelper
    {
        public static SqlConnection GetConnection(string name, IConfiguration config)
        {
            return new SqlConnection(config.GetConnectionString("TaskZ_Data"));
        }
    }
}
