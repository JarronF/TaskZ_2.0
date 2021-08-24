using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_Core.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }
        public int? ParentID { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public DateTime DueDate { get; set; }
        public int? MinutesSpent { get; set; }
        public int? MinutesEstimated { get; set; }
        public int? AssignedUserId { get; set; }
        //public ApplicationUser AssignedUser { get; set; }
        public TaskItem Parent { get; set; }
        public ICollection<TaskItem> Children { get; set; }
        // public int? TaskCommentId { get; set; }
        public ICollection<TaskComment> Comments { get; set; }
    }
}
