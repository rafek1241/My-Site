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

        public virtual async Task<T[]> Get()
        {
            var result = await HttpClient.GetJsonAsync<T[]>(ResourceBaseUrl);
            Console.WriteLine(result.ToString());
            return result;
        }

        public virtual async Task<T> Get(long itemId)
        {
            return await HttpClient.GetJsonAsync<T>($"{ResourceBaseUrl}/{itemId}");
        }

        public virtual async Task<ResponseModel> Add(T item)
        {
            var response = await HttpClient.PostJsonAsync<ResponseModel>(ResourceBaseUrl, item);

            return response;
        }

        public virtual async Task<ResponseModel> Update(long itemId, T item)
        {
            return await HttpClient.PutJsonAsync<ResponseModel>($"{ResourceBaseUrl}/{itemId}", item);
        }

        public virtual async Task<ResponseModel> Remove(T item)
        {
            var response = await HttpClient.SendJsonAsync<ResponseModel>(HttpMethod.Delete, ResourceBaseUrl, item);

            return response;
        }
    }
}
