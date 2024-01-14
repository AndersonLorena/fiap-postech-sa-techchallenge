using AL.Fiap.PosTech.TechChallenge.Application.CommandHandlers.Base;
using AL.Fiap.PosTech.TechChallenge.Domain.Entities;
using AL.Fiap.PosTech.TechChallenge.Domain.Repositories;
using AL.Fiap.PosTech.TechChallenge.Ports.Commands;
using AL.Fiap.PosTech.TechChallenge.Ports.Queries;
using AutoMapper;

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
}