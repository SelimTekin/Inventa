using Inventa.Product.Application.Features.CQRS.Handlers.ProductHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductImageHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.ProductTagHandlers;
using Inventa.Product.Application.Features.CQRS.Handlers.TagHandlers;
using Inventa.Product.Application.Interfaces;
using Inventa.Product.Application.Services;
using Inventa.Product.Persistence.Context;
using Inventa.Product.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplicationService(builder.Configuration);

// Add services to the container.
builder.Services.AddDbContext<ProductDbContext>();

#region
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductImageRepository, ProductImageRepository>();
builder.Services.AddScoped<IProductTagRepository, ProductTagRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();
builder.Services.AddScoped<IBrandRepository, BrandRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
#endregion

#region
builder.Services.AddScoped<CreateProductCommandHandler>();
builder.Services.AddScoped<UpdateProductCommandHandler>();
builder.Services.AddScoped<RemoveProductCommandHandler>();
builder.Services.AddScoped<GetProductByIdQueryHandler>();
builder.Services.AddScoped<GetProductQueryHandler>();

builder.Services.AddScoped<CreateProductImageCommandHandler>();
builder.Services.AddScoped<UpdateProductImageCommandHandler>();
builder.Services.AddScoped<RemoveProductImageCommandHandler>();
builder.Services.AddScoped<GetProductImageByIdQueryHandler>();
builder.Services.AddScoped<GetProductImageQueryHandler>();

builder.Services.AddScoped<CreateProductTagCommandHandler>();
builder.Services.AddScoped<RemoveProductTagCommandHandler>();
builder.Services.AddScoped<GetProductTagByIdQueryHandler>();
builder.Services.AddScoped<GetProductTagQueryHandler>();

builder.Services.AddScoped<CreateTagCommandHandler>();
builder.Services.AddScoped<UpdateTagCommandHandler>();
builder.Services.AddScoped<RemoveTagCommandHandler>();
builder.Services.AddScoped<GetTagByIdQueryHandler>();
builder.Services.AddScoped<GetTagQueryHandler>();
#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
