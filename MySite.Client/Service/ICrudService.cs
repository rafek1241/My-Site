using System.Collections.Generic;
using System.Threading.Tasks;
using MySite.Shared.Models;
using MySite.Shared.Models.Utils;

namespace MySite.Client.Service
{
    public interface ICrudService<T> where T : class, new()
    {
        Task<T[]> Get();

        Task<T> Get(long id);
        
        Task<ResponseModel> Add(T item);

        Task<ResponseModel> Update(long id, T item);

        Task<ResponseModel> Remove(T item);
    }
}