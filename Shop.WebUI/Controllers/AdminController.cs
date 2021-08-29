using Microsoft.AspNetCore.Mvc;
using Shop.Application.Commands.Products.Interfaces;
using Shop.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IGetProduct _getProductService;
        private readonly IGetProducts _getProductsService;
        private readonly ICreateProduct _createProductService;
        private readonly IDeleteProduct _deleteProductService;
        private readonly IUpdateProduct _updateProductService;

        public AdminController(
            IGetProduct getProductService,
            IGetProducts getProductsService,
            ICreateProduct createProductService,
            IDeleteProduct deleteProductService,
            IUpdateProduct updateProductService)
        {
            _getProductService = getProductService;
            _getProductsService = getProductsService;
            _createProductService = createProductService;
            _deleteProductService = deleteProductService;
            _updateProductService = updateProductService;
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id) => Ok(_getProductService.Do(id));

        [HttpGet]
        public IActionResult GetProducts() => Ok(_getProductsService.Do());

        [HttpPost]
        public IActionResult CreateProduct(ProductViewModel product) => Ok(_createProductService.Do(product));

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id) => Ok(_deleteProductService.Do(id));

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(ProductViewModel product) => Ok(_updateProductService.Do(product));
    }
}
