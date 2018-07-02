using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySite.Shared.Models;

namespace MySite.Server.Repositories
{
    public class MottoRepository : Repository, IMottoRepository
    {
        public MottoRepository(MySiteContext context) : base(context)
        {
        }

        public async Task<Motto[]> GetAsync()
        {
            return await db.Mottoes.ToArrayAsync();
        }

        public async Task<Motto> GetAsync(long id)
        {
            return await db.Mottoes.SingleAsync(p => p.MottoId == id);
        }
    }
}