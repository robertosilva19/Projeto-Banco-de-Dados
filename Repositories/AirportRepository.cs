using MongoDB.Driver;
using Projeto_Banco_de_Dados.Models;

namespace Projeto_Banco_de_Dados.Repositories
{
    public class AirportRepository : IAirportRepository
    {
        private readonly MongoDBSettings _mongoDBSettings;

        private readonly IMongoCollection<Airport> _airportsCollection;
       
        public AirportRepository(IConfiguration mongoDBSettings)
        {
            _mongoDBSettings = new MongoDBSettings();

            var client = new MongoClient(_mongoDBSettings.ConnectionString);
            var database = client.GetDatabase(_mongoDBSettings.DatabaseName);
            var collection = database.GetCollection<Airport>(_mongoDBSettings.CollectionName);

            _airportsCollection = database.GetCollection<Airport>(_mongoDBSettings.CollectionName);
        }

        public Task CreateAirportAsync(Airport airport)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAirportAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Airport> GetAirportByNameAsync(string name)
        {
            return await _airportsCollection.Find(a => a.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Airport>> GetAirportsAsync()
        {
            return await _airportsCollection.Find(_ => true).ToListAsync();
        }

        public Task<bool> UpdateAirportAsync(string id, Airport airport)
        {
            throw new NotImplementedException();
        }
    }
}
