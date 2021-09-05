

using Shop.Domain.Models;

namespace Shop.Application.Commands.Products.Interfaces
{
    public interface IGetProduct
    {
        Product Do(int id);
    }
}