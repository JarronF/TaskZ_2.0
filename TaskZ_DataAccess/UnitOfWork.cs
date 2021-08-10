using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskZ_Application.Interfaces;

namespace TaskZ_DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        public ITaskItemRepository TaskItems { get; }
        public ITaskCommentRepository TaskComments { get; }
        public UnitOfWork(ITaskItemRepository taskItemRepository, ITaskCommentRepository taskCommentRepository)
        {
            TaskItems = taskItemRepository;
            TaskComments = taskCommentRepository;
        }
       
    }
}
