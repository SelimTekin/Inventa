using Inventa.Product.Application.Features.Mediator.Commands.CategoryCommands;
using Inventa.Product.Application.Features.Mediator.Queries.CategoryQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventa.Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _mediator.Send(new GetCategoryQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById(Guid id)
        {
            var values = await _mediator.Send(new GetCategoryByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori başarıyla eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok("Kategori başarıyla güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(Guid id)
        {
            await _mediator.Send(new RemoveCategoryCommand(id));
            return Ok("Kategori başarıyla silindi");
        }
    }
}
