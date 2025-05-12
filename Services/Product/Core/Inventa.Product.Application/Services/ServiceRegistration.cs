using Inventa.Product.Application.Common.Behaviors;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Inventa.Product.Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));

            #region
            services.AddScoped<CreateProductCommandHandler>();
            services.AddScoped<UpdateProductCommandHandler>();
            services.AddScoped<RemoveProductCommandHandler>();
            services.AddScoped<GetProductByIdQueryHandler>();
            services.AddScoped<GetProductQueryHandler>();

            services.AddScoped<CreateProductImageCommandHandler>();
            services.AddScoped<UpdateProductImageCommandHandler>();
            services.AddScoped<RemoveProductImageCommandHandler>();
            services.AddScoped<GetProductImageByIdQueryHandler>();
            services.AddScoped<GetProductImageQueryHandler>();

            services.AddScoped<CreateProductTagCommandHandler>();
            services.AddScoped<RemoveProductTagCommandHandler>();
            services.AddScoped<GetProductTagByIdQueryHandler>();
            services.AddScoped<GetProductTagQueryHandler>();

            services.AddScoped<CreateTagCommandHandler>();
            services.AddScoped<UpdateTagCommandHandler>();
            services.AddScoped<RemoveTagCommandHandler>();
            services.AddScoped<GetTagByIdQueryHandler>();
            services.AddScoped<GetTagQueryHandler>();
            #endregion
        }
    }
}
