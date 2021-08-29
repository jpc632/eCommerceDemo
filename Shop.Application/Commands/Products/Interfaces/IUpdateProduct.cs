using Shop.Application.ViewModels;
using System.Threading.Tasks;

namespace Shop.Application.Commands.Products.Interfaces
{
    public interface IUpdateProduct
    {
        Task Do(ProductViewModel product);
    }
}