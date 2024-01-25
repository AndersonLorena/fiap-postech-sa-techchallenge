using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Ports.Commands
{
    public sealed class CreateProductCategoryCommand : CreateCommandBase<ProductCategoryEntity>
    {
        public string Name { get; set; } = null!;
    }

    public sealed class CreateProductCategoryCommandValidator : AbstractValidator<CreateProductCategoryCommand>
    {
        public CreateProductCategoryCommandValidator()
        {
        }
    }

    public sealed class UpdateProductCategoryCommand : UpdateCommandBase<ProductCategoryEntity>
    {
        public string Name { get; set; } = null!;
    }

    public sealed class UpdateProductCategoryCommandValidator : AbstractValidator<UpdateProductCategoryCommand>
    {
        public UpdateProductCategoryCommandValidator()
        {
        }
    }

    public sealed class DeleteProductCategoryCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteProductCategoryCommandValidator : AbstractValidator<DeleteProductCategoryCommand>
    {
        public DeleteProductCategoryCommandValidator()
        {
        }
    }
}