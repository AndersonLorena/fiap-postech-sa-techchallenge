using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
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