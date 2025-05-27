using Projeto_Banco_de_Dados.Models;

namespace Projeto_Banco_de_Dados.Services
{
    public interface IAirportService
    {
        Task<IEnumerable<Airport>> GetAirportsAsync();
        Task<Airport> GetAirportByNameAsync(string id);
        Task CreateAirportAsync(Airport airport);
        Task<bool> UpdateAirportAsync(string id, Airport airport);
        Task<bool> DeleteAirportAsync(string id);
    }
}
