using Inventa.Product.Application.Features.CQRS.Commands.ProductImageCommands;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers;
using Inventa.Product.Application.Features.CQRS.Queries.ProductImageQueries;
using Microsoft.AspNetCore.Mvc;

namespace Inventa.Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {
        private readonly CreateProductImageCommandHandler _createProductImageCommandHandler;
        private readonly UpdateProductImageCommandHandler _updateProductImageCommandHandler;
        private readonly RemoveProductImageCommandHandler _deleteProductImageCommandHandler;
        private readonly GetProductImageByIdQueryHandler _getProductImageByIdQueryHandler;
        private readonly GetProductImageQueryHandler _getProductImageQueryHandler;

        public ProductImagesController(CreateProductImageCommandHandler createProductImageCommandHandler, UpdateProductImageCommandHandler updateProductImageCommandHandler, RemoveProductImageCommandHandler deleteProductImageCommandHandler, GetProductImageByIdQueryHandler getProductImageByIdQueryHandler, GetProductImageQueryHandler getProductImageQueryHandler)
        {
            _createProductImageCommandHandler = createProductImageCommandHandler;
            _updateProductImageCommandHandler = updateProductImageCommandHandler;
            _deleteProductImageCommandHandler = deleteProductImageCommandHandler;
            _getProductImageByIdQueryHandler = getProductImageByIdQueryHandler;
            _getProductImageQueryHandler = getProductImageQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> ProductImageList()
        {
            var values = await _getProductImageQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById(Guid id)
        {
            var values = await _getProductImageByIdQueryHandler.Handle(new GetProductImageByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductImage(CreateProductImageCommand command)
        {
            await _createProductImageCommandHandler.Handle(command);
            return Ok("Ürün Resmi başarıyla eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage(UpdateProductImageCommand command)
        {
            await _updateProductImageCommandHandler.Handle(command);
            return Ok("Ürün Resmi başarıyla güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductImage(Guid id)
        {
            await _deleteProductImageCommandHandler.Handle(new RemoveProductImageCommand(id));
            return Ok("Ürün Resmi başarıyla silindi");
        }
    }
}
