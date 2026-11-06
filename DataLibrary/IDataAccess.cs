using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string query, U parameters, string connectionString);
        Task SaveData<T>(string query, T parameters, string connectionString);
    }
}
