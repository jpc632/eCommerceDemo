using System.Threading.Tasks;

namespace Shop.WebUI.Services
{
    public interface IHttpService
    {
        Task CreateAsync<T>(string addressExtension, T model);
        Task DeleteAsync(string addressExtension);
        Task<T> GetAsync<T>(string addressExtension);
        Task UpdateAsync<T>(string addressExtension, T model);
    }
}