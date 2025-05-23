﻿using Inventa.Product.Application.Features.Mediator.Queries.BrandQueries;
using Inventa.Product.Application.Features.Mediator.Results.BrandResults;
using Inventa.Product.Application.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Inventa.Product.Application.Features.Mediator.Handlers.BrandHandlers
{
    public class GetBrandQueryHandler : IRequestHandler<GetBrandQuery, List<GetBrandQueryResult>>
    {
        private readonly IBrandRepository _brandRepository;
        public GetBrandQueryHandler(IBrandRepository brandRepository, ILogger<GetBrandQueryHandler> logger)
        {
            _brandRepository = brandRepository;
        }
        public async Task<List<GetBrandQueryResult>> Handle(GetBrandQuery request, CancellationToken cancellationToken)
        {
            var values = await _brandRepository.GetAllAsync();
            return values.Select(x => new GetBrandQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                Country = x.Country,
                LogoUrl = x.LogoUrl
            }).ToList();
        }
    }
}
