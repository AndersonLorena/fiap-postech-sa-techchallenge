using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Interfaces.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateOrderCommandsHandler : CreateCommandBaseHandler<CreateOrderCommand, OrderEntity>
    {
        public CreateOrderCommandsHandler(
            IPersistenceRepository<OrderEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateOrderCommandsHandler : UpdateCommandBaseHandler<UpdateOrderCommand, OrderEntity>
    {
        public UpdateOrderCommandsHandler(
            IPersistenceRepository<OrderEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteOrderCommandsHandler : DeleteCommandBaseHandler<DeleteOrderCommand, OrderEntity>
    {
        public DeleteOrderCommandsHandler(
            IPersistenceRepository<OrderEntity> persistenceRepository,
            IQueryRepository<OrderEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }
}