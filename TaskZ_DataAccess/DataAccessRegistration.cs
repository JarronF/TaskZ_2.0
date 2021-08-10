using Microsoft.Extensions.DependencyInjection;
using TaskZ_Application.Interfaces;
using TaskZ_DataAccess.Repositories;

namespace TaskZ_DataAccess
{
    public static class DataAccessRegistration
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddTransient<ITaskItemRepository, TaskItemRepository>();
            services.AddTransient<ITaskCommentRepository, TaskCommentRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
