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
    public class UpdateProduct : IUpdateProduct
    {
        private readonly ApplicationDbContext _context;

        public UpdateProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(Product vm)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == vm.Id);

            product.Name = vm.Name;
            product.Description = vm.Description;
            product.Value = vm.Value;

            await _context.SaveChangesAsync();
        }
    }
}
