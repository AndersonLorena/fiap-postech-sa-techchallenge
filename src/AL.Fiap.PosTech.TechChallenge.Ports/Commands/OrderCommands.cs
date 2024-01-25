using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class OrderItem
    {
        public Guid ProductId { get; set; }

        public IEnumerable<Guid> Ingredients { get; set; } = new List<Guid>();
    }

    public sealed class CreateOrderCommand : CreateCommandBase<OrderEntity>
    {
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }

    public sealed class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
        }
    }

    public sealed class UpdateOrderCommand : UpdateCommandBase<OrderEntity>
    {
        public decimal TotalAmount { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
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