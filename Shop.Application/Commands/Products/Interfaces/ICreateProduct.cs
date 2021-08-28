using Shop.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Products.Interfaces
{
    public interface ICreateProduct
    {
        Task Do(ProductViewModel product);
    }
}
