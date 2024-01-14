using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
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