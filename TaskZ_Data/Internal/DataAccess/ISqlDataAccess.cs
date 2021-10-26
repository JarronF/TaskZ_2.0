using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskZ_Data.Internal.DataAccess
{
    public interface ISqlDataAccess
    {
        string ConnectionStringName { get; set; }
        Task<List<T>> LoadDataBySql<T>(string sql);
        void SaveDataBySql(string sql);
    }
}