using Microsoft.Extensions.DependencyInjection;
using TaskZ_Application.Interfaces;
using TaskZ_Data.Internal.DataAccess;
using TaskZ_Data.Repositories;

namespace TaskZ_Data
{
    public static class DataAccessRegistration
    {
        public static void AddDataAccess(this IServiceCollection services)
        {
            services.AddTransient<ITaskItemRepository, TaskItemRepository>();
            services.AddTransient<ITaskCommentRepository, TaskCommentRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<ISqlDataAccess, SqlDataAccess>();
        }
    }
}
