using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Dtos;
using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    public sealed class ProductIngredientController : CrudBaseController<
        CreateProductIngredientCommand,
        ProductIngredientReadResponseDto,
        UpdateProductIngredientCommand,
        DeleteProductIngredientCommand,
        ProductIngredientEntity>
    {
        public ProductIngredientController(
            ISender mediator,
            IQueryRepository<ProductIngredientEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}