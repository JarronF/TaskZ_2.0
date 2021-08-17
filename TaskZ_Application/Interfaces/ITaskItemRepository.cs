using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskZ_Core.Entities;

namespace TaskZ_Application.Interfaces
{
    public interface ITaskItemRepository: IGenericRepository<TaskItem>
    {
        Task<IEnumerable<TaskItem>> GetAllHighLevelTasksAsync();
        Task<IEnumerable<TaskItem>> GetChildTasksAsync(int parentId);
    }
}
