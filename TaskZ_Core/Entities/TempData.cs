using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskZ_Core.Entities
{
    public class TempData
    {
        private static readonly IEnumerable<TaskItem> temp_TaskItemsList = new List<TaskItem>()
            {
                new TaskItem
                {
                    Id = 1,
                    DueDate = DateTime.Parse("2021/06/15 10:00:00"),
                    Title = "Try to take over the world",
                    ShortDescription = "We need to attempt to control the entire world. Starting from A proceeding to Z",
                    AssignedUserId = 1
                },
                new TaskItem
                {
                    Id = 2,
                    ParentID = 1,
                    DueDate = DateTime.Parse("2021/06/15 10:00:00"),
                    Title = "Find Pinky",
                    ShortDescription = "Pinky can do the hard work",
                    AssignedUserId = 2
                },
                new TaskItem
                {
                    Id = 3,
                    ParentID = 1,
                    DueDate = DateTime.Parse("2021/06/15 10:00:00"),
                    Title = "Find Brain",
                    ShortDescription = "Brain will control the operation",
                    AssignedUserId = 1
                }
        };
        public static Task<IEnumerable<TaskItem>> Temp_GetAllTaskItems()
        {
            return Task.FromResult(temp_TaskItemsList);
        }
        public static TaskComment GetComment()
        {
            return new TaskComment
            {
                Id = 1,
                UserId = 1,
                Comment = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                            "In tincidunt justo vulputate tristique ultrices. Praesent nec auctor erat. Ut ante ex, rhoncus id felis vel, porta molestie massa. " +
                            "Sed malesuada pharetra sapien sed laoreet. Aenean in diam nec sapien lacinia cursus sed ultrices eros. Duis et sagittis diam, eu condimentum odio. " +
                            "Integer convallis nibh feugiat congue tincidunt. Vestibulum bibendum condimentum erat. Praesent sit amet pretium leo, sit amet interdum eros. " +
                            "Nam fringilla pellentesque finibus.",
                CommentDate = DateTime.Now,
                TaskItemId = 1
            };
        }
    }
}
