using Inventa.Product.Application.Features.Mediator.Commands.BrandCommands;
using Inventa.Product.Application.Features.Mediator.Queries.BrandQueries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Inventa.Product.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BrandsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var values = await _mediator.Send(new GetBrandQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBrandById(Guid id)
        {
            var values = await _mediator.Send(new GetBrandByIdQuery(id));
            return Ok(values);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka başarıyla eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _mediator.Send(command);
            return Ok("Marka başarıyla güncellendi");
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(Guid id)
        {
            await _mediator.Send(new RemoveBrandCommand(id));
            return Ok("Marka başarıyla silindi");
        }
    }
}
