using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskZ_Application.Interfaces;
using TaskZ_Core.Entities;
using TaskZ_DataAccess.Utilities;

namespace TaskZ_DataAccess.Repositories
{
    public class TaskCommentRepository : ITaskCommentRepository
    {
        private readonly IConfiguration _config;
        public TaskCommentRepository(IConfiguration config)
        {
            _config = config;
        }
        private IDbConnection Connection
        {
            get
            {
                return DatabaseHelper.GetConnection("TaskZ_Data", _config);
            }
        }

        public Task<int> AddAsync(TaskComment entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskComment>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskComment> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(TaskComment entity)
        {
            throw new NotImplementedException();
        }
    }
}
