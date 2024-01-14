using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

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
}