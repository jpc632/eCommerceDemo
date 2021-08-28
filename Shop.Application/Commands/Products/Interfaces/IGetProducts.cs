using Shop.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Commands.Products.Interfaces
{
    public interface IGetProducts
    {
        IEnumerable<ProductViewModel> Do();
    }
}
