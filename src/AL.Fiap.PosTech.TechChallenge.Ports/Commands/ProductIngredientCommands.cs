using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateProductIngredientCommand : CreateCommandBase<ProductIngredientEntity>
    {
        public int ProductId { get; set; }

        public int IngredientId { get; set; }
    }

    public sealed class CreateProductIngredientCommandValidator : AbstractValidator<CreateProductIngredientCommand>
    {
        public CreateProductIngredientCommandValidator()
        {
        }
    }

    public sealed class UpdateProductIngredientCommand : UpdateCommandBase<ProductIngredientEntity>
    {
        public int ProductId { get; set; }

        public int IngredientId { get; set; }
    }

    public sealed class UpdateProductIngredientCommandValidator : AbstractValidator<UpdateProductIngredientCommand>
    {
        public UpdateProductIngredientCommandValidator()
        {
        }
    }

    public sealed class DeleteProductIngredientCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteProductIngredientCommandValidator : AbstractValidator<DeleteProductIngredientCommand>
    {
        public DeleteProductIngredientCommandValidator()
        {
        }
    }
}