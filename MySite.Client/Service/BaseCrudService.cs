using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
using MySite.Shared.Models.Utils;

namespace MySite.Client.Service
{
    public abstract class BaseCrudService<T> : ICrudService<T> where T : class, new()
    {
        [Inject]
        public HttpClient HttpClient { get; }

        public string ResourceBaseUrl { get; set; }

        public async Task<T[]> Get()
        {
            var result = await HttpClient.GetJsonAsync<T[]>(ResourceBaseUrl);
            Console.WriteLine(result.ToString());
            return result;
        }

        public async Task<T> Get(long itemId)
        {
            return await HttpClient.GetJsonAsync<T>($"{ResourceBaseUrl}/{itemId}");
        }

        public async Task<ResponseModel> Add(T item)
        {
            var response = await HttpClient.PostJsonAsync<ResponseModel>(ResourceBaseUrl, item);

            return response;
        }

        public async Task<ResponseModel> Update(long itemId, T item)
        {
          throw new NotImplementedException();
        }

        public async Task<ResponseModel> Remove(T item)
        {
            var response = await HttpClient.SendJsonAsync<ResponseModel>(HttpMethod.Delete, ResourceBaseUrl, item);

            return response;
        }
    }
}
