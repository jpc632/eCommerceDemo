using Shop.Application.Commands.Products.Interfaces;
using Shop.Infastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Commands.Products
{
    public class DeleteProduct : IDeleteProduct
    {
        private readonly ApplicationDbContext _context;

        public DeleteProduct(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Do(int id)
        {
            var product = _context.Products.FirstOrDefault(x => x.Id == id);
            _context.Products.Remove(product);

            await _context.SaveChangesAsync();
        }
    }
}
