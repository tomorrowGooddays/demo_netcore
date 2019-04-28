using Domain.IRepository;
using MongoDB.Driver;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCore.Repository.MongoDB
{
    /// <summary>
    /// MongoDB数据库
    /// </summary>
    public class MongoDataAdapter : IDataAdapter<MongoClient>
    {
        public static ConcurrentDictionary<string, MongoClient> Databases { get; set; } = new ConcurrentDictionary<string, MongoClient>();
        public MongoClient Database => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public MongoClient GetConnection(string connStr)
        {
            throw new NotImplementedException();
        }

        public async Task<MongoClient> GetConnectionAsync(string name)
        {
            try
            {
                if (!Databases.TryGetValue(name, out MongoClient database) || null == database)
                {
                    //string connStr = _configuration.ConfigurationExtension.GetConfigInfo<string>(name, "");根据数据库名称获取数据库连接配置
                    string connStr = "";
                    if (!string.IsNullOrEmpty(connStr))
                    {

                        database = new MongoClient(connStr);
                        Databases.TryAdd(name, database);
                    }
                }

                return database;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }

        public Task<MongoClient> GetConnectionAsync()
        {
            throw new NotImplementedException();
        }
    }
}
