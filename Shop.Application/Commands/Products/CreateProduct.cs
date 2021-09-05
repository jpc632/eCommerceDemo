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
    public class CreateProduct : ICreateProduct
    {
        private readonly ApplicationDbContext _context;

        public CreateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(Product vm)
        {
            _context.Add(new Product
            {
                Name = vm.Name,
                Description = vm.Description,
                Value = vm.Value
            });

            await _context.SaveChangesAsync();
        }
    }
}
