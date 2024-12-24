using System.Collections.Generic;
using System.Threading.Tasks;

namespace HealthAppFrontend.DataRepository.IDataRepository
{
    public interface IDataRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync(string ApiURL);

        Task<T> GetByIdAsync(string ApiURL);

        Task<bool> InsertAsync(string ApiURL, T newObject);

        Task<bool> UpdateAsync(string ApiURL, T newObject);

        Task<bool> DeleteAsync(string ApiURL);

    }
}
