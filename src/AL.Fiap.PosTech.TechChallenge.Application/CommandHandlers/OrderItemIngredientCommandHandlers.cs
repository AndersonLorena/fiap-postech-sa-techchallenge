using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateOrderItemIngredientCommandsHandler : CreateCommandBaseHandler<CreateOrderItemIngredientCommand, OrderItemIngredientEntity>
    {
        public CreateOrderItemIngredientCommandsHandler(
            IPersistenceRepository<OrderItemIngredientEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateOrderItemIngredientCommandsHandler : UpdateCommandBaseHandler<UpdateOrderItemIngredientCommand, OrderItemIngredientEntity>
    {
        public UpdateOrderItemIngredientCommandsHandler(
            IPersistenceRepository<OrderItemIngredientEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteOrderItemIngredientCommandsHandler : DeleteCommandBaseHandler<DeleteOrderItemIngredientCommand, OrderItemIngredientEntity>
    {
        public DeleteOrderItemIngredientCommandsHandler(
            IPersistenceRepository<OrderItemIngredientEntity> persistenceRepository,
            IQueryRepository<OrderItemIngredientEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }
}