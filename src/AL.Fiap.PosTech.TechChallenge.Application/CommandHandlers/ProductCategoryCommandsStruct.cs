using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands.Base;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;
using FluentValidation;

namespace AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers
{
    public class CreateProductCategoryCommandsHandler : CreateCommandBaseHandler<CreateProductCategoryCommand, ProductCategoryEntity>
    {
        public CreateProductCategoryCommandsHandler(
            IPersistenceRepository<ProductCategoryEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class UpdateProductCategoryCommandsHandler : UpdateCommandBaseHandler<UpdateProductCategoryCommand, ProductCategoryEntity>
    {
        public UpdateProductCategoryCommandsHandler(
            IPersistenceRepository<ProductCategoryEntity> persistenceRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                mapper)
        { }
    }

    public sealed class DeleteProductCategoryCommandsHandler : DeleteCommandBaseHandler<DeleteProductCategoryCommand, ProductCategoryEntity>
    {
        public DeleteProductCategoryCommandsHandler(
            IPersistenceRepository<ProductCategoryEntity> persistenceRepository,
            IQueryRepository<ProductCategoryEntity> queryRepository,
            IMapper mapper)
            : base(
                persistenceRepository,
                queryRepository,
                mapper)
        { }
    }

    public sealed class CreateProductCategoryCommand : CreateCommandBase
    {
        public string Name { get; set; } = null!;
    }

    public sealed class CreateProductCategoryCommandValidator : AbstractValidator<CreateProductCategoryCommand>
    {
        public CreateProductCategoryCommandValidator()
        {
        }
    }

    public sealed class UpdateProductCategoryCommand : UpdateCommandBase
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