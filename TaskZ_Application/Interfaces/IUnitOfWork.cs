using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_Application.Interfaces
{
    public interface IUnitOfWork
    {
        ITaskItemRepository TaskItems { get; }
        ITaskCommentRepository TaskComments { get; }
    }
}
