using AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers.Base;
using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries.Dtos;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AL.Fiap.PosTech.TechChallenge.Adapters.Entrypoints.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public sealed class OrderController : CrudBaseController<
        CreateOrderCommand,
        OrderDto,
        UpdateOrderCommand,
        DeleteOrderCommand,
        OrderEntity>
    {
        public OrderController(
            ISender mediator,
            IQueryRepository<OrderEntity> queryRepository,
            IMapper mapper)
            : base(
                  mediator,
                  queryRepository,
                  mapper)
        {
        }
    }
}