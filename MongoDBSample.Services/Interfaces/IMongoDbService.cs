using MongoDB.Driver;

namespace MongoDBSample.Services.Interfaces
{
    public interface IMongoDbService
    {
        public IMongoDatabase Db { get; set; }
    }
}