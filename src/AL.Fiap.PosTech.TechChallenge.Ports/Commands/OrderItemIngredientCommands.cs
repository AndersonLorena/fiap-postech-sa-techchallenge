using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
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