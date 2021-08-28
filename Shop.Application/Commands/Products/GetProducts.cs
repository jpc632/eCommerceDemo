using Shop.Application.Commands.Products.Interfaces;
using Shop.Infastructure.Persistence;
using Shop.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Commands.Products
{
    public class GetProducts : IGetProducts
    {
        private readonly ApplicationDbContext _context;

        public GetProducts(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductViewModel> Do() =>
            _context.Products.ToList().Select(x => new ProductViewModel
            { 
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            });
    }
}
