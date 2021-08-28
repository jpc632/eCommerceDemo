using System.Threading.Tasks;

namespace Shop.Application.Commands.Products.Interfaces
{
    public interface IDeleteProduct
    {
        Task Do(int id);
    }
}