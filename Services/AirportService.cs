using Projeto_Banco_de_Dados.Models;
using Projeto_Banco_de_Dados.Repositories;

namespace Projeto_Banco_de_Dados.Services
{
    public class AirportService : IAirportService
    {
        private readonly IAirportRepository _airportRepository;
        public AirportService(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        public Task CreateAirportAsync(Airport airport)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAirportAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Airport> GetAirportByNameAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Airport>> GetAirportsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAirportAsync(string id, Airport airport)
        {
            throw new NotImplementedException();
        }
    }
}
