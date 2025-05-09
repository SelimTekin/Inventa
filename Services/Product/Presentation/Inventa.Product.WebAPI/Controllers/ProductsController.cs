using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers;
using Inventa.Product.Application.Features.CQRS.Queries.ProductQueries;
using Microsoft.AspNetCore.Mvc;

namespace Inventa.Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly CreateProductCommandHandler _createProductCommandHandler;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        private readonly RemoveProductCommandHandler _deleteProductCommandHandler;
        private readonly GetProductByIdQueryHandler _getProductByIdQueryHandler;
        private readonly GetProductQueryHandler _getProductQueryHandler;

        public ProductsController(CreateProductCommandHandler createProductCommandHandler, UpdateProductCommandHandler updateProductCommandHandler, RemoveProductCommandHandler deleteProductCommandHandler, GetProductByIdQueryHandler getProductByIdQueryHandler, GetProductQueryHandler getProductQueryHandler)
        {
            _createProductCommandHandler = createProductCommandHandler;
            _updateProductCommandHandler = updateProductCommandHandler;
            _deleteProductCommandHandler = deleteProductCommandHandler;
            _getProductByIdQueryHandler = getProductByIdQueryHandler;
            _getProductQueryHandler = getProductQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ProductList()
        {
            var values = await _getProductQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var values = await _getProductByIdQueryHandler.Handle(new GetProductByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommand command)
        {
            await _createProductCommandHandler.Handle(command);
            return Ok("Ürün başarıyla eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommand command)
        {
            await _updateProductCommandHandler.Handle(command);
            return Ok("Ürün başarıyla güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            await _deleteProductCommandHandler.Handle(new RemoveProductCommand(id));
            return Ok("Ürün başarıyla silindi");
        }
    }
}
