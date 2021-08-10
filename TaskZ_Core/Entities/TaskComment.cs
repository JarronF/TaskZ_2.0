using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_Core.Entities
{
    public class TaskComment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        //public ApplicationUser User { get; set; }
        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }
        public int TaskItemId { get; set; }
        public TaskItem ParentTaskItem { get; set; }
    }
}
