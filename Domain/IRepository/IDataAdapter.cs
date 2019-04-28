using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.IRepository
{
    public interface IDataAdapter<T> where T : class
    {
        T Database { get; }

        string Name { get; }

        T GetConnection(string connStr);
        Task<T> GetConnectionAsync(string connStr);


        Task<T> GetConnectionAsync();
    }
}
