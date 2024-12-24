using HealthAppFrontend.DataRepository.IDataRepository;
using HealthAppFrontend.Models;
using System.Net.Http;

namespace HealthAppFrontend.DataRepository
{
    public class MedicalCenterRepository : DataRepository<MedicalCenterFront>, IMedicalCenterRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public MedicalCenterRepository(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}
