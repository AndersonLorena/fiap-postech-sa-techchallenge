using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

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
}