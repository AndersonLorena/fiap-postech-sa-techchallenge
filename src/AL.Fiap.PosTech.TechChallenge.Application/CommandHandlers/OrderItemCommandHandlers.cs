using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateOrderItemCommandsHandler : CreateCommandBaseHandler<CreateOrderItemCommand, OrderItemEntity>
    {
        public CreateOrderItemCommandsHandler(
            IPersistenceRepository<OrderItemEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateOrderItemCommandsHandler : UpdateCommandBaseHandler<UpdateOrderItemCommand, OrderItemEntity>
    {
        public UpdateOrderItemCommandsHandler(
            IPersistenceRepository<OrderItemEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteOrderItemCommandsHandler : DeleteCommandBaseHandler<DeleteOrderItemCommand, OrderItemEntity>
    {
        public DeleteOrderItemCommandsHandler(
            IPersistenceRepository<OrderItemEntity> persistenceRepository,
            IQueryRepository<OrderItemEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }
}