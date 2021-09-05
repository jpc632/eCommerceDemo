
using Shop.Domain.Models;
using System.Threading.Tasks;

namespace Shop.Application.Commands.Products.Interfaces
{
    public interface IUpdateProduct
    {
        Task Do(Product product);
    }
}