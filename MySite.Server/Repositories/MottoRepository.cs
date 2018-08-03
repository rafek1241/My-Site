using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySite.Shared.Models;

namespace MySite.Server.Repositories
{
    public class MottoRepository : Repository, IMottoRepository
    {
        public MottoRepository(MySiteContext context) : base(context)
        {
        }
        [HttpGet]
        public async Task<Motto[]> GetAsync()
        {
            return await db.Mottoes.ToArrayAsync();
        }

        [HttpGet("{id}")]
        public async Task<Motto> GetAsync(long id)
        {
            return await db.Mottoes.SingleAsync(p => p.MottoId == id);
        }
    }
}