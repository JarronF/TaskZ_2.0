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
using TaskZ_Data.Internal.DataAccess;

namespace TaskZ_Data.Repositories
{
    public class TaskCommentRepository : ITaskCommentRepository
    {
        private readonly ISqlDataAccess _data;
        public TaskCommentRepository(ISqlDataAccess data)
        {
            _data = data;
        }

        public Task<int> AddAsync(TaskComment entity)
        {
            throw new NotImplementedException();            
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskComment>> GetAllAsync()
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
