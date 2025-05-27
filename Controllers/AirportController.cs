using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Banco_de_Dados.Models;
using Projeto_Banco_de_Dados.Repositories;

namespace Projeto_Banco_de_Dados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportRepository _airportRepository;

        public AirportController(IAirportRepository airportRepository)
        {
            _airportRepository = airportRepository;
        }

        [HttpGet]
        public async Task<IEnumerable<Airport>> GetAirports()
        {
            return await _airportRepository.GetAirportsAsync();

        }
    }
}
