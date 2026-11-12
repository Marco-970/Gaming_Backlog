using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DataLibrary
{
    public class DataAccess : IDataAccess
    {
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var result = await connection.QueryAsync<T>(sql, parameters);
                return result.ToList();
            };
        }
        public async Task<int> LoadId<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                var result = await connection.QueryFirstOrDefaultAsync<int>(sql, parameters);
                return result;
            };
        }

        public async Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }

        public async Task<int> InsertGameAndReturnId<T>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
                return await connection.QuerySingleAsync<int>("SELECT LAST_INSERT_ID()"); 
            }
        }
    }
}
