using Domain.DBEntity;
using Domain.IRepository;
using Domain.IService;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Service
{
    public class LoginService : ILoginService
    {
        private const string DBName = "LoginInfo";
        private IDataAdapter<MongoClient> _dataAdapter;

        public LoginService(IDataAdapter<MongoClient> dataAdapter)
        {
            this._dataAdapter = dataAdapter;
        }
        public async Task CheckLoginInfo(string userName, string password)
        {
            if (_dataAdapter != null)
            {
                IMongoClient client = await _dataAdapter.GetConnectionAsync(DBName);
                var db = client.GetDatabase(DBName);

                var coll = db.GetCollection<LoginInfoModel>("LoginModel");


                await coll.InsertOneAsync(new LoginInfoModel()
                {
                    Username = "test",
                    Password = "111"
                });

            }
        }
    }
}
