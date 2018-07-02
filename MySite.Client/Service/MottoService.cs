using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using MySite.Shared.Models;
using MySite.Shared.Models.Utils;

namespace MySite.Client.Service
{
    public class MottoService : IMottoService
    {
        private const string _mottoBaseUrl = "/api/Motto";

        public MottoService(HttpClient client)
        {
            HttpClient = client;
        }

        public HttpClient HttpClient { get; }

        public async Task<Motto[]> Get()
        {
            return await HttpClient.GetJsonAsync<Motto[]>(_mottoBaseUrl);
        }

        public async Task<Motto> Get(long id)
        {
            return await HttpClient.GetJsonAsync<Motto>($"{_mottoBaseUrl}/{id}");
        }

        public async Task<ResponseModel> Add(Motto item)
        {
            return await HttpClient.PostJsonAsync<ResponseModel>(_mottoBaseUrl, item);
        }

        public async Task<ResponseModel> Update(long id, Motto item)
        {
            return await HttpClient.PutJsonAsync<ResponseModel>($"{_mottoBaseUrl}/{id}", item);
        }

        public async Task<ResponseModel> Remove(Motto item)
        {
            return await HttpClient.SendJsonAsync<ResponseModel>(HttpMethod.Delete, _mottoBaseUrl, item);
        }
    }
}
