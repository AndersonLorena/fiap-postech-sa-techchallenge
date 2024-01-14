using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateOrderStatusCommandsHandler : CreateCommandBaseHandler<CreateOrderStatusCommand, OrderStatusEntity>
    {
        public CreateOrderStatusCommandsHandler(
            IPersistenceRepository<OrderStatusEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateOrderStatusCommandsHandler : UpdateCommandBaseHandler<UpdateOrderStatusCommand, OrderStatusEntity>
    {
        public UpdateOrderStatusCommandsHandler(
            IPersistenceRepository<OrderStatusEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteOrderStatusCommandsHandler : DeleteCommandBaseHandler<DeleteOrderStatusCommand, OrderStatusEntity>
    {
        public DeleteOrderStatusCommandsHandler(
            IPersistenceRepository<OrderStatusEntity> persistenceRepository,
            IQueryRepository<OrderStatusEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }
}