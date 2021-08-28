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
    public class GetProduct : IGetProduct
    {
        private readonly ApplicationDbContext _context;

        public GetProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public ProductViewModel Do(int id) =>
            _context.Products.Where(x => x.Id == id).Select(x => new ProductViewModel
            {
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            })
            .FirstOrDefault();
    }
}
