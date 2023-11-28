using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

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
                queryRepository,
                mapper)
        { }
    }

    public sealed class CreateOrderCommand : CreateCommandBase
    {
        public int OrderStatusId { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<CreateOrderItemCommand> OrderItems { get; set; } = new List<CreateOrderItemCommand>();
    }

    public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
        }
    }

    public sealed class UpdateOrderCommand : UpdateCommandBase
    {
        public int OrderStatusId { get; set; }

        public decimal TotalAmount { get; set; }

        public ICollection<CreateOrderItemCommand> OrderItems { get; set; } = new List<CreateOrderItemCommand>();
    }

    public sealed class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
        }
    }

    public sealed class DeleteOrderCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
    {
        public DeleteOrderCommandValidator()
        {
        }
    }
}