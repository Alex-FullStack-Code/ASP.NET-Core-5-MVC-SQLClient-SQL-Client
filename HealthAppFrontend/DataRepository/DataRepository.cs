using HealthAppFrontend.DataRepository.IDataRepository;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HealthAppFrontend.DataRepository
{
    public class DataRepository<T> : IDataRepository<T> where T : class
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public DataRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IEnumerable<T>> GetAllAsync(string ApiURL)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ApiURL);

            var client = _httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringJson = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<IEnumerable<T>>(stringJson);
            }
            return null;
        }

        public async Task<T> GetByIdAsync(string ApiURL)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, ApiURL);

            var client = _httpClientFactory.CreateClient();

            HttpResponseMessage response = await client.SendAsync(request);

            //HttpResponseMessage response = await client.GetAsync(ApiURL);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringJson = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(stringJson);
            }
            return null;
        }

        public async Task<bool> InsertAsync(string ApiURL, T newObject)
        {

            var client = _httpClientFactory.CreateClient();
            var stringPayload = JsonConvert.SerializeObject(newObject);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync(ApiURL, httpContent);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateAsync(string ApiURL, T newObject)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, ApiURL);

            var client = _httpClientFactory.CreateClient();
            var stringPayload = JsonConvert.SerializeObject(newObject);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PutAsync(ApiURL, httpContent);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteAsync(string ApiURL)
        {            

            var client = _httpClientFactory.CreateClient();            

            HttpResponseMessage response = await client.DeleteAsync(ApiURL);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringJson = await response.Content.ReadAsStringAsync();

                return true;
            }
            return false;
        }
    }
}
