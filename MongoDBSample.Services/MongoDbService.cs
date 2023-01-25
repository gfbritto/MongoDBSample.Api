using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDBSample.Models.Appsettings;
using MongoDBSample.Services.Interfaces;

namespace MongoDBSample.Services
{
    public class MongoDbService : IMongoDbService
    {
        public IMongoDatabase Db { get; set; }

        public MongoDbService(IOptions<MongoDbSettings> mongoDBSettings)
        {
            var client = new MongoClient(mongoDBSettings.Value.ConnectionString);
            Db = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        }
    }
}
