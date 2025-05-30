using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Banco_de_Dados.Models;
using Projeto_Banco_de_Dados.Repositories;
using Projeto_Banco_de_Dados.Services;

namespace Projeto_Banco_de_Dados.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService _airportService;

        public AirportController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpGet("ALL")]
        public async Task<IEnumerable<Airport>> GetAirports()
        {
            return await _airportService.GetAirportsAsync();

        }

        [HttpGet("ByName/{name}")]

        public async Task<ActionResult<Airport>> GetAirportByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return BadRequest("O nome do aeroporto não pode ser vazio ou nulo.");
            }

            var airport = await _airportService.GetAirportByNameAsync(name);

            if (airport == null)
            {
                return NotFound($"O aeroporto '{name}' não foi encontrado.");
            }
            return Ok(airport);
        }
    }
}
