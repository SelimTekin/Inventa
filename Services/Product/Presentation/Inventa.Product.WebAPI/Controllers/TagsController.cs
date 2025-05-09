using Inventa.Product.Application.Features.CQRS.Commands.ProductCommands;
using Inventa.Product.Application.Features.CQRS.Commands.TagCommands;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers;
using Inventa.Product.Application.Features.CQRS.Queries.ProductQueries;
using Inventa.Product.Application.Features.CQRS.Queries.TagQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventa.Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly CreateTagCommandHandler _createTagCommandHandler;
        private readonly GetTagByIdQueryHandler _getTagByIdQueryHandler;
        private readonly GetTagQueryHandler _getTagQueryHandler;
        private readonly UpdateTagCommandHandler _updateTagCommandHandler;
        private readonly RemoveTagCommandHandler _removeTagCommandHandler;
        public TagsController(CreateTagCommandHandler createTagCommandHandler, GetTagByIdQueryHandler getTagByIdQueryHandler, GetTagQueryHandler getTagQueryHandler, UpdateTagCommandHandler updateTagCommandHandler, RemoveTagCommandHandler removeTagCommandHandler)
        {
            _createTagCommandHandler = createTagCommandHandler;
            _getTagByIdQueryHandler = getTagByIdQueryHandler;
            _getTagQueryHandler = getTagQueryHandler;
            _updateTagCommandHandler = updateTagCommandHandler;
            _removeTagCommandHandler = removeTagCommandHandler;
        }
        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var values = await _getTagQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagById(Guid id)
        {
            var values = await _getTagByIdQueryHandler.Handle(new GetTagByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand command)
        {
            await _createTagCommandHandler.Handle(command);
            return Ok("Etiket başarıyla eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand command)
        {
            await _updateTagCommandHandler.Handle(command);
            return Ok("Etiket başarıyla güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTag(Guid id)
        {
            await _removeTagCommandHandler.Handle(new RemoveTagCommand(id));
            return Ok("Etiket başarıyla silindi");
        }
    }
}
