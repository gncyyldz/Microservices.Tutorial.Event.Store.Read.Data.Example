using MongoDB.Driver;

namespace Shared.Services.Abstractions
{
    public interface IMongoDBService
    {
        IMongoCollection<T> GetCollection<T>(string collectionName);
        IMongoDatabase GetDatabase(string databaseName, string connectionString);
    }
}
