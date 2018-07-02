using System.Threading.Tasks;
using MySite.Shared.Models;

namespace MySite.Server.Repositories
{
    public interface IMottoRepository
    {
        Task<Motto[]> GetAsync();
        Task<Motto> GetAsync(long id);
    }
}