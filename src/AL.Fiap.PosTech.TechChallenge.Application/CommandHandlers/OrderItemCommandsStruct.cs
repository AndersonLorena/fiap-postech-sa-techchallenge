using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

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

    public sealed class CreateOrderItemCommand : CreateCommandBase
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal ItemPrice { get; set; }

        public ICollection<CreateOrderItemIngredientCommand> OrderItemIngredients { get; set; } = new List<CreateOrderItemIngredientCommand>();
    }

    public sealed class CreateOrderItemCommandValidator : AbstractValidator<CreateOrderItemCommand>
    {
        public CreateOrderItemCommandValidator()
        {
        }
    }

    public sealed class UpdateOrderItemCommand : UpdateCommandBase
    {
        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public decimal ItemPrice { get; set; }

        public ICollection<CreateOrderItemIngredientCommand> OrderItemIngredients { get; set; } = new List<CreateOrderItemIngredientCommand>();
    }

    public sealed class UpdateOrderItemCommandValidator : AbstractValidator<UpdateOrderItemCommand>
    {
        public UpdateOrderItemCommandValidator()
        {
        }
    }

    public sealed class DeleteOrderItemCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteOrderItemCommandValidator : AbstractValidator<DeleteOrderItemCommand>
    {
        public DeleteOrderItemCommandValidator()
        {
        }
    }
}