using Shop.Application.Commands.Products.Interfaces;
using Shop.Domain.Models;
using Shop.Infastructure.Persistence;

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

        public Product Do(int id) =>
            _context.Products.Where(x => x.Id == id).Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Value = x.Value
            })
            .FirstOrDefault();
    }
}
