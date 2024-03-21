using MongoDB.Driver;
using Microsoft.Extensions.Options;
using PORTAFOLIO.PortafolioAPI.Models;
using PORTAFOLIO.PortafolioAPI.Configurations;

namespace PortafolioAPI.Services
{
    public class PortafolioService
    {
        private readonly IMongoCollection<Datos> _datosCollection;
        
       public PortafolioService(IOptions<DatabaseSettings> databaseSetting)
        {
            var mongoClient = new MongoClient(databaseSetting.Value.ConnectionString);
            
            var mongoDB = mongoClient.GetDatabase(databaseSetting.Value.DatabaseName);
            _datosCollection = mongoDB.GetCollection<Datos>(databaseSetting.Value.CollectionName);
        }
        public async Task<List<Datos>> GetAsync() =>
            await _datosCollection.Find(_ => true).ToListAsync();
    }
}
