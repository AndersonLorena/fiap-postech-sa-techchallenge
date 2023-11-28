using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateProductIngredientCommandsHandler : CreateCommandBaseHandler<CreateProductIngredientCommand, ProductIngredientEntity>
    {
        public CreateProductIngredientCommandsHandler(
            IPersistenceRepository<ProductIngredientEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateProductIngredientCommandsHandler : UpdateCommandBaseHandler<UpdateProductIngredientCommand, ProductIngredientEntity>
    {
        public UpdateProductIngredientCommandsHandler(
            IPersistenceRepository<ProductIngredientEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteProductIngredientCommandsHandler : DeleteCommandBaseHandler<DeleteProductIngredientCommand, ProductIngredientEntity>
    {
        public DeleteProductIngredientCommandsHandler(
            IPersistenceRepository<ProductIngredientEntity> persistenceRepository,
            IQueryRepository<ProductIngredientEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }

    public sealed class CreateProductIngredientCommand : CreateCommandBase
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

    public sealed class UpdateProductIngredientCommand : UpdateCommandBase
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