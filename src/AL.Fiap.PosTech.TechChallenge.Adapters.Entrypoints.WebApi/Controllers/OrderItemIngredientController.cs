using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos;
using AutoMapper;
using MediatR;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    public sealed class OrderItemIngredientController : CrudBaseController<
        CreateOrderItemIngredientCommand,
        OrderItemIngredientDto,
        UpdateOrderItemIngredientCommand,
        DeleteOrderItemIngredientCommand,
        OrderItemIngredientEntity>
    {
        public OrderItemIngredientController(
            ISender mediator,
            IQueryRepository<OrderItemIngredientEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}