using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateProductCommandsHandler : CreateCommandBaseHandler<CreateProductCommand, ProductEntity>
    {
        public CreateProductCommandsHandler(
            IPersistenceRepository<ProductEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateProductCommandsHandler : UpdateCommandBaseHandler<UpdateProductCommand, ProductEntity>
    {
        public UpdateProductCommandsHandler(
            IPersistenceRepository<ProductEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteProductCommandsHandler : DeleteCommandBaseHandler<DeleteProductCommand, ProductEntity>
    {
        public DeleteProductCommandsHandler(
            IPersistenceRepository<ProductEntity> persistenceRepository,
            IQueryRepository<ProductEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }

    public sealed class CreateProductCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }

        public ICollection<CreateProductIngredientCommand> ProductIngredients { get; set; } = new List<CreateProductIngredientCommand>();
    }

    public sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
        }
    }

    public sealed class UpdateProductCommand : UpdateCommandBase
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public decimal Price { get; set; }

        public int ProductCategoryId { get; set; }

        public ICollection<CreateProductIngredientCommand> ProductIngredients { get; set; } = new List<CreateProductIngredientCommand>();
    }

    public sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
    {
        public UpdateProductCommandValidator()
        {
        }
    }

    public sealed class DeleteProductCommand : DeleteCommandBase
    {
    }

    public sealed class DeleteProductCommandValidator : AbstractValidator<DeleteProductCommand>
    {
        public DeleteProductCommandValidator()
        {
        }
    }
}