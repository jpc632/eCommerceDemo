using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shop.WebUI.Services
{
    public class HttpService : IHttpService
    {
        private readonly IHttpClientFactory _clientFactory;

        public HttpService(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        private string baseUrl = "https://localhost:44354/api/";

        private HttpRequestMessage BuildRequest(string addressExtension, HttpMethod method)
        {
            var url = baseUrl + addressExtension;

            var request = new HttpRequestMessage(method, url);
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("User-Agent", "HttpClientFactory-Sample");

            return request;
        }

        private HttpRequestMessage BuildRequest(string addressExtension, HttpMethod method, HttpContent content)
        {
            var request = BuildRequest(addressExtension, method);
            request.Content = content;

            return request;
        }

        public async Task CreateAsync<T>(string addressExtension, T model)
        {
            var content = new StringContent(JsonSerializer.Serialize<T>(model), Encoding.UTF8, "application/json");
            var request = BuildRequest(addressExtension, HttpMethod.Post, content);

            var client = _clientFactory.CreateClient();
            await client.SendAsync(request);
        }

        public async Task<T> GetAsync<T>(string addressExtension)
        {
            var request = BuildRequest(addressExtension, HttpMethod.Get);
            var client = _clientFactory.CreateClient();
            var response = await client.SendAsync(request);

            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<T>(responseStream);
        }

        public async Task DeleteAsync(string addressExtension)
        {
            var request = BuildRequest(addressExtension, HttpMethod.Delete);
            var client = _clientFactory.CreateClient();

            await client.SendAsync(request);
        }
    }
}
