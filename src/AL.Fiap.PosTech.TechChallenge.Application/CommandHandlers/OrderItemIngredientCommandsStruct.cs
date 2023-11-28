using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

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

    public sealed class CreateOrderItemIngredientCommand : CreateCommandBase
    {
        public int OrderItemId { get; set; }

        public int IngredientId { get; set; }
    }

    public sealed class CreateOrderItemIngredientCommandValidator : AbstractValidator<CreateOrderItemIngredientCommand>
    {
        public CreateOrderItemIngredientCommandValidator()
        {
        }
    }

    public sealed class UpdateOrderItemIngredientCommand : UpdateCommandBase
    {
        public int OrderItemId { get; set; }

        public int IngredientId { get; set; }
    }

    public sealed class UpdateOrderItemIngredientCommandValidator : AbstractValidator<UpdateOrderItemIngredientCommand>
    {
        public UpdateOrderItemIngredientCommandValidator()
        {
        }
    }

    public sealed class DeleteOrderItemIngredientCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteOrderItemIngredientCommandValidator : AbstractValidator<DeleteOrderItemIngredientCommand>
    {
        public DeleteOrderItemIngredientCommandValidator()
        {
        }
    }
}