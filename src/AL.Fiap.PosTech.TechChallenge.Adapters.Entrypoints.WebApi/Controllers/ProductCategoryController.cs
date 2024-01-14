using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos;
using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    public sealed class ProductCategoryController : CrudBaseController<
        CreateProductCategoryCommand,
        ProductCategoryReadResponseDto,
        UpdateProductCategoryCommand,
        DeleteProductCategoryCommand,
        ProductCategoryEntity>
    {
        public ProductCategoryController(
            ISender mediator,
            IQueryRepository<ProductCategoryEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}