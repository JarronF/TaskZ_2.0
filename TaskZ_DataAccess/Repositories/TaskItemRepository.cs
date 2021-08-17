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
    //TODO: Make adhoc queries into stored procedures
    public class TaskItemRepository : ITaskItemRepository
    {
        private readonly IConfiguration _config;
        public TaskItemRepository(IConfiguration config)
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

        public Task<int> AddAsync(TaskItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            string sql = @"SELECT   Id, ParentID, Title, ShortDescription, DueDate, 
                                    MinutesSpent, MinutesEstimated, AssignedUserId
                           FROM TaskItem";

            using (Connection)
            {
                var result = await Connection.QueryAsync<TaskItem>(sql);
                return result.ToList();
            }
        }
        public async Task<IEnumerable<TaskItem>> GetAllHighLevelTasksAsync()
        {
            string sql = @"SELECT   Id, ParentID, Title, ShortDescription, DueDate, 
                                    MinutesSpent, MinutesEstimated, AssignedUserId
                           FROM TaskItem
                           WHERE ParentId IS NULL";

            using (Connection)
            {
                var result = await Connection.QueryAsync<TaskItem>(sql);
                return result.ToList();
            }
        }

        public async Task<TaskItem> GetByIdAsync(int id)
        {
            string sql = @"SELECT Id, ParentID, Title, ShortDescription, DueDate, 
                                  MinutesSpent, MinutesEstimated, AssignedUserId 
                           FROM TaskItem WHERE Id = @Id";

            using (Connection)
            {
                var result = await Connection.QueryFirstAsync<TaskItem>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IEnumerable<TaskItem>> GetChildTasksAsync(int parentId)
        {
            string sql = @"SELECT Id, ParentID, Title, ShortDescription, DueDate, 
                                  MinutesSpent, MinutesEstimated, AssignedUserId 
                           FROM TaskItem WHERE ParentId = @parentId";

            using (Connection)
            {
                var result = await Connection.QueryAsync<TaskItem>(sql, new { ParentId = parentId });
                return result.ToList();
            }
        }

        public Task<int> UpdateAsync(TaskItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
