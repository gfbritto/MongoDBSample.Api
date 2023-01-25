using System.Linq.Expressions;

namespace MongoDBSample.Repository.Generic
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> FindOneAsync(Expression<Func<T, bool>> filterExpression);

        Task<T> FindByIdAsync(string id);

        Task<IEnumerable<T>> FindAll();

        Task InsertOneAsync(T document);

        Task InsertManyAsync(ICollection<T> documents);

        Task ReplaceOneAsync(T document);

        Task DeleteOneAsync(Expression<Func<T, bool>> filterExpression);

        Task DeleteByIdAsync(string id);

        Task DeleteManyAsync(Expression<Func<T, bool>> filterExpression);
    }
}
