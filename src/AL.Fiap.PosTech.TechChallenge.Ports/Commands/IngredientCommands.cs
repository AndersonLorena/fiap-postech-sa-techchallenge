using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateIngredientCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }
    }

    public sealed class CreateIngredientCommandValidator : AbstractValidator<CreateIngredientCommand>
    {
        public CreateIngredientCommandValidator()
        {
        }
    }

    public sealed class UpdateIngredientCommand : UpdateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }
    }

    public sealed class UpdateIngredientCommandValidator : AbstractValidator<UpdateIngredientCommand>
    {
        public UpdateIngredientCommandValidator()
        {
        }
    }

    public sealed class DeleteIngredientCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteIngredientCommandValidator : AbstractValidator<DeleteIngredientCommand>
    {
        public DeleteIngredientCommandValidator()
        {
        }
    }
}