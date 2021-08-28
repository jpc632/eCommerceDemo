using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Shop.Application.Products;
using Shop.Application.Products.Interfaces;
using Shop.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.UI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICreateProduct _service;

        public IndexModel(ILogger<IndexModel> logger, ICreateProduct service)
        {
            _logger = logger;
            _service = service;
        }

        [BindProperty]
        public ProductViewModel Product { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _service.Do(Product);

            return RedirectToPage(nameof(Index));
        }
    }
}