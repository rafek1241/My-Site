using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySite.Server.Repositories;
using MySite.Shared.Models;

namespace MySite.Server.Controllers
{
    [Route("api/motto")]
    public class MottoController
    {
        private readonly IMottoRepository _mottoRepository;

        public MottoController(IMottoRepository mottoRepository)
        {
            _mottoRepository = mottoRepository;
        }

        [HttpGet]
        public async Task<Motto[]> GetAsync()
        {
            return await _mottoRepository.GetAsync();
        }

        [HttpGet("/{id}")]
        public async Task<Motto> GetAsync(long id)
        {
            return await _mottoRepository.GetAsync(id);
        }
    }
}