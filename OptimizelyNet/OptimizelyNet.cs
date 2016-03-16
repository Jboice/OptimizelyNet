using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using OptimizelyNet.DTO;

namespace OptimizelyNet
{
    public class OptimizelyNet
    {
        private const string BaseUrl = "https://www.optimizelyapis.com";
        private const string ApiVersion = "v1";
        private readonly HttpClient _client;

        public OptimizelyNet(string apiToken)
        {
            _client = new HttpClient {BaseAddress = new Uri(BaseUrl)};
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("token", apiToken);
        }

        public async Task<T> ExecuteAsync<T>(string request) where T : new()
        {
            HttpResponseMessage response = await _client.GetAsync(request);

            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException("Error retrieving data");
            }

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(content, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
