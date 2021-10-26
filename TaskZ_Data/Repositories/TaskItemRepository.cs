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
    //TODO: Make adhoc queries into stored procedures
    public class TaskItemRepository : ITaskItemRepository
    {
        private readonly ISqlDataAccess _data;
        public TaskItemRepository(ISqlDataAccess data)
        {
            _data = data;
        }
        public Task<int> AddAsync(TaskItem entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TaskItem>> GetAllAsync()
        {
            string sql = @"SELECT   Id, ParentID, Title, ShortDescription, DueDate, 
                                    MinutesSpent, MinutesEstimated, AssignedUserId
                           FROM TaskItem";

            var taskList = await _data.LoadDataBySql<TaskItem>(sql);
            return taskList;
        }
        public async Task<IEnumerable<TaskItem>> GetAllHighLevelTasksAsync()
        {            
            string sql = @"SELECT PT.Id, PT.ParentID, PT.Title, PT.ShortDescription, PT.DueDate, 
                                  PT.MinutesSpent, PT.MinutesEstimated, PT.AssignedUserId, COUNT(CT.Id) AS SubtaskCount
                            FROM  TaskItem PT LEFT JOIN TaskItem CT
                                  ON PT.Id = CT.ParentID
                                  WHERE PT.ParentId IS NULL
                                  GROUP BY PT.Id, PT.ParentID, PT.Title, PT.ShortDescription, PT.DueDate, 
                                           PT.MinutesSpent, PT.MinutesEstimated, PT.AssignedUserId";
            
            var taskList = await _data.LoadDataBySql<TaskItem>(sql);
            return taskList;
        }
        public async Task<TaskItem> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
            //string sql = @"SELECT Id, ParentID, Title, ShortDescription, DueDate, 
            //                      MinutesSpent, MinutesEstimated, AssignedUserId 
            //               FROM TaskItem WHERE Id = @Id";

            //using (Connection)
            //{
            //    var result = await Connection.QueryFirstAsync<TaskItem>(sql, new { Id = id });
            //    return result;
            //}
        }

        public async Task<IEnumerable<TaskItem>> GetChildTasksAsync(int parentId)
        {
            throw new NotImplementedException();
            //string sql = @"SELECT Id, ParentID, Title, ShortDescription, DueDate, 
            //                      MinutesSpent, MinutesEstimated, AssignedUserId 
            //               FROM TaskItem WHERE ParentId = @parentId";

            //using (Connection)
            //{
            //    var result = await Connection.QueryAsync<TaskItem>(sql, new { ParentId = parentId });
            //    return result.ToList();
            //}
        }

        public Task<int> UpdateAsync(TaskItem entity)
        {
            throw new NotImplementedException();
        }
    }
}
