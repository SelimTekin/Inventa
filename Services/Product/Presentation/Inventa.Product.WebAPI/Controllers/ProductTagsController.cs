using Inventa.Product.Application.Features.CQRS.Commands.ProductTagCommands;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers;
using Inventa.Product.Application.Features.CQRS.Queries.ProductTagQueries;
using Microsoft.AspNetCore.Mvc;

namespace Inventa.Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTagsController : ControllerBase
    {
        private readonly CreateProductTagCommandHandler _createProductTagCommandHandler;
        private readonly RemoveProductTagCommandHandler _deleteProductTagCommandHandler;
        private readonly GetProductTagByIdQueryHandler _getProductTagByIdQueryHandler;
        private readonly GetProductTagQueryHandler _getProductTagQueryHandler;
        public ProductTagsController(CreateProductTagCommandHandler createProductTagCommandHandler, RemoveProductTagCommandHandler deleteProductTagCommandHandler, GetProductTagByIdQueryHandler getProductTagByIdQueryHandler, GetProductTagQueryHandler getProductTagQueryHandler)
        {
            _createProductTagCommandHandler = createProductTagCommandHandler;
            _deleteProductTagCommandHandler = deleteProductTagCommandHandler;
            _getProductTagByIdQueryHandler = getProductTagByIdQueryHandler;
            _getProductTagQueryHandler = getProductTagQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> ProductTagList()
        {
            var values = await _getProductTagQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductTagById(Guid id)
        {
            var values = await _getProductTagByIdQueryHandler.Handle(new GetProductTagByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProductTag(CreateProductTagCommand command)
        {
            await _createProductTagCommandHandler.Handle(command);
            return Ok("Ürün Etiketi başarıyla eklendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProductTag(Guid id)
        {
            await _deleteProductTagCommandHandler.Handle(new RemoveProductTagCommand(id));
            return Ok("Ürün Etiketi başarıyla silindi");
        }
    }
}
