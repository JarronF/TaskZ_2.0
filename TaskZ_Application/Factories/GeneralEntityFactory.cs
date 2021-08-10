using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskZ_Core.Entities;

namespace TaskZ_Application.Factories
{
    public static class GeneralEntityFactory
    {
        public static TaskItem CreateNewTaskItem()
        {
            return new TaskItem();
        }

        public static List<TaskItem> CreateNewTaskItemList()
        {
            return new List<TaskItem>();
        }
    }
}
