using MongoDB.Driver;
using MongoDBSample.Services.Interfaces;
using System.Linq.Expressions;

namespace MongoDBSample.Repository.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IMongoDbService _mongoDbService;
        private readonly IMongoCollection<T> _collection;

        public GenericRepository(IMongoDbService mongoDbService)
        {
            _mongoDbService = mongoDbService;
            _collection = _mongoDbService.Db.GetCollection<T>("customers");
        }


        public Task DeleteByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteManyAsync(Expression<Func<T, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOneAsync(Expression<Func<T, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> FindAll()
        {
            return await _collection.Find(_ => true).ToListAsync();
        }

        public Task<T> FindByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> FindOneAsync(Expression<Func<T, bool>> filterExpression)
        {
            throw new NotImplementedException();
        }

        public Task InsertManyAsync(ICollection<T> documents)
        {
            throw new NotImplementedException();
        }

        public async Task InsertOneAsync(T document)
        {
            await _collection.InsertOneAsync(document);
        }

        public Task ReplaceOneAsync(T document)
        {
            throw new NotImplementedException();
        }
    }
}
