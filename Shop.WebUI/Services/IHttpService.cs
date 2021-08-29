using System.Threading.Tasks;

namespace Shop.WebUI.Services
{
    public interface IHttpService
    {
        Task CreateAsync<T>(string addressExtension, T model);
        Task<T> GetAsync<T>(string addressExtension);
        Task DeleteAsync(string addressExtension);
    }
}