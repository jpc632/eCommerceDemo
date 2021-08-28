using Shop.UI.ViewModels;

namespace Shop.Application.Commands.Products.Interfaces
{
    public interface IGetProduct
    {
        ProductViewModel Do(int id);
    }
}