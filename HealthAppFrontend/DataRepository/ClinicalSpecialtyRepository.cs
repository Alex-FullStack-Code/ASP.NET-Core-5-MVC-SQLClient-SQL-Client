using HealthAppFrontend.DataRepository.IDataRepository;
using HealthAppFrontend.Models;
using System.Net.Http;

namespace HealthAppFrontend.DataRepository
{
    public class ClinicalSpecialtyRepository : DataRepository<ClinicalSpecialtyFront>, IClinicalSpecialtyRepository
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public ClinicalSpecialtyRepository(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}
